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


        ///// <summary>
        ///// Search orders.
        ///// </summary>
        ///// <param name="inicioPedido">First order search criteria.</param>
        ///// <param name="finPedido"> Final order search criteria.</param>
        ///// <returns>List of persons.</returns>
        //public List<PersonDataAccess> SearchOrder(DateTime inicioPedido, DateTime finPedido)
        //{
        //    // Init return value
        //    List<PersonDataAccess> personList = new List<PersonDataAccess>();

        //    SqlConnection conn = new SqlConnection(base.ConnectionString);

        //    SqlDataReader reader = null;

        //    try
        //    {
        //        // Open connection
        //        conn.Open();

        //        // Init command
        //        SqlCommand cmd = new SqlCommand()
        //        {
        //            Connection = conn
        //        };

        //        // Set query
        //        StringBuilder query = new StringBuilder();

        //        query.Append(" SELECT BusinessEntityID, PersonType, NameStyle, Title, FirstName, MiddleName, LastName ");
        //        query.Append("   FROM Person.Person ");
        //        query.Append("  WHERE 1 = 1 ");


        //        cmd.CommandText = query.ToString();

        //        // Execute
        //        reader = cmd.ExecuteReader();

        //        // Read
        //        while (reader.Read())
        //        {
        //            Person actualPerson = new Person();

        //            actualPerson.ID = Convert.ToInt32(reader["BusinessEntityID"]);

        //            actualPerson.FirstName = reader["FirstName"].ToString();


        //            personList.Add(actualPerson);
        //        }

        //    }
        //    catch
        //    {
        //        // Do not use "throw ex" because it loses the stack
        //        throw;
        //    }
        //    finally
        //    {
        //        // Close datareader
        //        if (reader != null)
        //        {
        //            reader.Close();
        //        }

        //        // Close connection
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }

        //    return personList;
        //}







        //           -------------------- CAMBIAR REMOVE PHONE POR BORRAR EL PEDIDO   ---------------------------

        ///// <summary>
        ///// Remove Order.
        ///// </summary>
        ///// <param name="phone">Remove order</param>
        ///// <returns>List of mails.</returns>
        //public void Remove(Phone phone)
        //{

        //    SqlConnection conn = new SqlConnection(base.ConnectionString);

        //    try
        //    {
        //        // Open connection
        //        conn.Open();

        //        // Set query
        //        StringBuilder query = new StringBuilder();

        //        query.Append(" DELETE FROM Person.PersonPhone ");
        //        query.Append("       WHERE BusinessEntityID  = @personId ");
        //        query.Append("         AND PhoneNumber       = @phoneNumber ");
        //        query.Append("         AND PhoneNumberTypeID = @phoneTypeId ");

        //        // Init command
        //        SqlCommand cmd = new SqlCommand(query.ToString(), conn);

        //        SqlParameter paramId = new SqlParameter("@personId", phone.PersonId);
        //        cmd.Parameters.Add(paramId);

        //        SqlParameter paramNumber = new SqlParameter("@phoneNumber", phone.Number);
        //        cmd.Parameters.Add(paramNumber);

        //        SqlParameter paramTypeId = new SqlParameter("@phoneTypeId", phone.TypeId);
        //        cmd.Parameters.Add(paramTypeId);

        //        // Execute
        //        cmd.ExecuteNonQuery();

        //    }
        //    catch
        //    {
        //        // Do not use "throw ex" because it loses the stack
        //        throw;
        //    }
        //    finally
        //    {
        //        // Close connection
        //        if (conn != null)
        //        {
        //            conn.Close();
        //        }
        //    }
        //}


    }
}