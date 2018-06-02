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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void frmBase_Load(object sender, EventArgs e)
        {

        }


        #region Show Messages

        /// <summary>
        /// Message type.
        /// </summary>
        public enum MessageType
        {
            Info,
            Error
        }

        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="title">Title.</param>
        /// <param name="messageType">Message type.</param>
        public void ShowMessage(string message)
        {
            ShowMessage(message, "Info");
        }


        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="title">Title.</param>
        /// <param name="messageType">Message type.</param>
        public void ShowMessage(string message, string title)
        {
            ShowMessage(message, title, MessageType.Info);
        }


        /// <summary>
        /// Show message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="title">Title.</param>
        /// <param name="messageType">Message type.</param>
        public void ShowMessage(string message, string title, MessageType messageType)
        {
            // Set message box icon
            MessageBoxIcon icon = MessageBoxIcon.Information;

            switch (messageType)
            {
                case MessageType.Error:
                    icon = MessageBoxIcon.Error;
                    break;
                case MessageType.Info:
                    icon = MessageBoxIcon.Information;
                    break;
            }

            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);

        }

        /// <summary>
        /// Show confirmation message.
        /// </summary>
        /// <param name="message">Message.</param>
        /// <param name="title">Title.</param>
        /// <returns>Dialog result: Yes/No</returns>
        public DialogResult ShowConfirmationMessage(string message, string title)
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        #endregion Show Messages 

        #region Error management

        /// <summary>
        /// Manage error.
        /// </summary>
        /// <param name="ex">Exception.</param>
        public void ManageError(Exception ex)
        {

            ShowMessage("There was an error:\n" + ex.Message, "Error", MessageType.Error);
        }

        /// <summary>
        /// Manage error.
        /// </summary>
        /// <param name="ex">Exception.</param>
        /// <param name="message">Message.</param>
        public void ManageError(Exception ex, string message)
        {

            ShowMessage(message + ":\n" + ex.Message, "Error", MessageType.Error);
        }

        /// <summary>
        /// Manage error.
        /// </summary>
        /// <param name="message">Message.</param>
        public void ManageError(string message)
        {
            ShowMessage(message, "Error", MessageType.Error);
        }

        #endregion Error management
    }
}