using Beca.BooksLibrary.Entities;
using System;
using System.Windows.Forms;

namespace Beca.BooksLibrary.Win
{
    /// <summary>
    /// Add book form.
    /// </summary>
    public partial class frmAddBook : FormBase
    {
        #region Properties
        
        /// <summary>
        /// New book added.
        /// </summary>
        public Book Book { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor;
        /// </summary>
        public frmAddBook()
        {
            InitializeComponent();
            base.InitializeForm();
        }

        #endregion Constructor

        #region Events

        /// <summary>
        /// Added button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void btnAccept_Click(object sender, EventArgs e)
        {
            Add();
        }
        
        /// <summary>
        /// Cancel button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        /// <summary>
        /// Pages textbox key press event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void txtPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #endregion Events

        #region Private methods

        /// <summary>
        /// Add book action.
        /// </summary>
        private void Add()
        {
            // Check required fields
            if ((!string.IsNullOrEmpty(txtTittle.Text.Trim())) &&
                (!string.IsNullOrEmpty(txtAuthor.Text.Trim())) &&
                (!string.IsNullOrEmpty(txtPages.Text.Trim())))
            {
                // Check if page value is an integer
                int pages;

                if (int.TryParse(txtPages.Text, out pages))
                {
                    // Fill new book info
                    this.Book = new Book();
                    this.Book.Tittle = txtTittle.Text.Trim();
                    this.Book.Author = txtAuthor.Text.Trim();
                    this.Book.Pages = pages;

                    // Close form
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Pages value must be an integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please, fill all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Cancel action.
        /// </summary>
        private void Cancel()
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        #endregion Private methods

       
    }
}
