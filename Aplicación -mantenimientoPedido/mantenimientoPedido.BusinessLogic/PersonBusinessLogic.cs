using mantenimientoPedido.DataAccess;
using mantenimientoPedido.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientoPedido.BusinessLogic
{
    public class PersonBusinessLogic
    {

        #region Global variables

        /// <summary>
        /// Person data access.
        /// </summary>
        private PersonDataAccess _personDataAccess;

        #endregion Global variables

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public PersonBusinessLogic()
        {
            _personDataAccess = new PersonDataAccess();
        }

        #endregion Constructors


        #region Public methods

        /// <summary>
        /// Validate person exist.
        /// </summary>
        /// <param name="customerID">Customer ID.</param>
        public bool PersonExist(int customerID)
        {
            // Validate if the phone already exists
            bool exist = _personDataAccess.PersonExist(customerID);

            
            return exist;
        }

        /// <summary>
        /// Get customer info.
        /// </summary>
        /// <param name="custumerId">Customer ID.</param>
        /// <returns>Person Details.</returns>
        public Customer getCustomerInfo(int custumerId)
        {
            Customer customerDataInfo = _personDataAccess.getCustomerInfo(custumerId);

            return customerDataInfo;
        }

        #endregion Public methods

    }
}
