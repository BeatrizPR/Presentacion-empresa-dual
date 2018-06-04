using mantenimientoPedido.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace mantenimientoPedido.DataAccess
{
    public class PersonDataAccess : DataAccessBase
    {

        /// <summary>
        /// Get person for loging.
        /// </summary>
        /// <param name="customerId">Customer ID.</param>
        /// <returns>Person Details.</returns>
        public bool PersonExist(int customerId)
        {

            // Init return value
            bool exist = false;

            SqlConnection conn = new SqlConnection(base.ConnectionString);

            try
            {
                // Open connection
                conn.Open();

                // Set query
                StringBuilder query = new StringBuilder();

                query.Append("  SELECT COUNT(CustomerID) ");
                query.Append("   FROM Sales.Customer ");
                query.Append("  WHERE CustomerID = @customerId ");

                // Init command
                SqlCommand cmd = new SqlCommand(query.ToString(), conn);

                SqlParameter paramId = new SqlParameter("@customerId", customerId);
                cmd.Parameters.Add(paramId);

                cmd.Connection = conn;
                cmd.CommandText = query.ToString();

                //Execute
                int count = (int)cmd.ExecuteScalar();

                exist = (count > 0);
            }
            catch
            {
                throw;
            }
            finally
            {
                // Close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return exist;
        }

        /// <summary>
        /// Info customer.
        /// </summary>
        /// <returns>List of data person.</returns>
        public Customer getCustomerInfo (int customerId)
        {
            // Init return value
            Customer customerData = new Customer();

            SqlConnection conn = new SqlConnection(base.ConnectionString);

            SqlDataReader reader = null;

            try
            {
                // Open connection
                conn.Open();

                // Set query
                StringBuilder query = new StringBuilder();

                query.Append(" SELECT  FirstName, Store.Name as 'Store', SalesTerritory.Name as 'Territory' ");
                query.Append("   FROM Sales.Customer ");
                query.Append("   left join Person.Person on Person.BusinessEntityID = Customer.PersonID ");
                query.Append("   left join Sales.Store on Store.BusinessEntityID = Customer.StoreID ");
                query.Append("  left join Sales.SalesTerritory on SalesTerritory.TerritoryID = Customer.TerritoryID ");
                query.Append("  WHERE CustomerID = @customerId ");

                // Init command
                SqlCommand cmd = new SqlCommand(query.ToString(), conn);

                SqlParameter paramId = new SqlParameter("@customerId", customerId);
                cmd.Parameters.Add(paramId);

                cmd.Connection = conn;
                cmd.CommandText = query.ToString();

                // Execute
                reader = cmd.ExecuteReader();

                // Read
                if(reader.Read())
                {

                    customerData.FirstName = reader["FirstName"].ToString();

                    customerData.Store = reader["Store"].ToString();

                    customerData.Territory = reader["Territory"].ToString();


                }
            }
            catch
            {
                throw;
            }
            finally
            {
                // Close datareader
                if (reader != null)
                {
                    reader.Close();
                }

                // Close connection
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return customerData;
        }


    }
}