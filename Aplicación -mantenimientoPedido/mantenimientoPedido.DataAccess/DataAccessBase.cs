using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientoPedido.DataAccess
{
    public class DataAccessBase
    {
        public string ConnectionString
        {
            get { return @"Data Source=(localdb)\MSSqllocalDB;Initial Catalog=AdventureWorks2014;Integrated Security=True"; }
        }

        /// <summary>
        /// Returns a partial search criteria.
        /// </summary>
        /// <param name="criteria">Criteria.</param>
        /// <returns>Partial criteria.</returns>
        public string ToPartialSearchCriteria(string criteria)
        {
            return '%' + criteria + '%';
        }

    }
}
