using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mantenimientoPedido.Entities
{
    public class Customer
    {
        /// <summary>
        /// ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// First name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Store.
        /// </summary>
        public string Store { get; set; }

        /// <summary>
        /// Territory.
        /// </summary>
        public string Territory { get; set; }

        
    }
}
