using mantenimientoPedido.BusinessLogic;
using mantenimientoPedido.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mantenimientoPedido
{
    public partial class frmMain : Form
    {
        private int customerID;
        #region Construct

        public frmMain()
        {
            InitializeComponent();
            InitializeForm();
        }

        public frmMain(int customerID)
        {
            InitializeComponent();
            InitializeForm();
            this.customerID = customerID;
        }

        #endregion Construct

        #region Global variables

        /// <summary>
        /// Person ID for data of custumer.
        /// </summary>
        private int custumerId;

        #endregion Global variables

        #region Events

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetPersonData();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStore_TextChanged(object sender, EventArgs e)
        {

        }

        private void texBTerritory_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxSearch_Enter(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }


        #endregion Events

        #region Methods

        /// <summary>
        /// Initialize form.
        /// </summary>
        private void InitializeForm()
        {
            
            // Disable customer data controls
            textBoxName.Enabled = false;
            textBoxStore.Enabled = false;
            texBTerritory.Enabled = false;

        }

        /// <summary>
        /// Set header info of customer
        /// </summary>
        private void SetPersonData()
        {
            try
            {
                PersonBusinessLogic personBL = new PersonBusinessLogic();

                Customer personDetails = personBL.getCustomerInfo(custumerId);

                // Set header info
                textBoxName.Text = personDetails.FirstName;
                textBoxStore.Text = personDetails.Store;
                texBTerritory.Text = personDetails.Territory;
            }
            catch //(Exception ex)
            {
                throw;
                // No me funciona lo de abajo - hago un throw
                // Base.ManageError(ex, "There was an error getting person details");
            }
        }


        #endregion Methods

        
    }
}
