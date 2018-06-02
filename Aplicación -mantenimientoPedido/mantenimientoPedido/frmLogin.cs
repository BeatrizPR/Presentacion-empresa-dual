using mantenimientoPedido.BusinessLogic;
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
    public partial class frmLogin : Base
    {
        #region Global Variables

        /// <summary>
        /// Customer Id.
        /// </summary>
        private int customerId;

        #endregion Global Variables

        #region Constructor

        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize form.
        /// </summary>
        private void InitializeForm()
        {
            // Disable conect button
            btnConectar.Enabled = false;

        }

        #endregion Constructor

        #region Events

        private void frmLogin_Load(object sender, EventArgs e)
        {

        } 

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';

            EnableConect();
        }

        private void textBoxIdUsu_TextChanged(object sender, EventArgs e)
        {
            EnableConect();
        }


        private void btnConectar_Click(object sender, EventArgs e)
        {
            comprobarLogin();
            showFormMain(customerId);
        }

        #endregion Events


        #region method

        private void PersonExist()
        {

            throw new NotImplementedException();
        }

        // Enable button Conect
        private void EnableConect()
        {
            if ((textBoxIdUsu.TextLength > 0) && (textBoxPassword.TextLength > 0))
            {
                btnConectar.Enabled = true;
            }
            else
            {
                btnConectar.Enabled = false;
            }

        }

        /// <summary>
        /// Validate Login
        /// </summary>
        private void comprobarLogin()
        {
            PersonBusinessLogic LoginBL = new PersonBusinessLogic();

            //Get search criteria
            string IDintroduced = textBoxIdUsu.Text;
            int id;


            if (int.TryParse(IDintroduced, out id))
            {
                if (LoginBL.PersonExist(id))
                {

                }
                else
                {
                    base.ShowMessage("El usuario no existe");

                    // data clear and focus on id 
                    textBoxIdUsu.Clear();
                    textBoxIdUsu.Focus();
                    textBoxPassword.Clear();

                }
            }
            else
            {
                base.ShowMessage("Tiene que introducir un numero");

                // data clear and focus on id 
                textBoxIdUsu.Clear();
                textBoxIdUsu.Focus();
                textBoxPassword.Clear();

            }

        }

        /// <summary>
        /// Method for show Main Form
        /// </summary>

        private void showFormMain (int customerId)
        {

            frmMain formMain = new frmMain(customerId);

            formMain.ShowDialog(this);

            //          form main show in front of login form
            //formMain.ShowD();
            //formMain.TopMost = true;
            //formMain.Activate();

            this.Hide();
        }



        #endregion method

    }
}