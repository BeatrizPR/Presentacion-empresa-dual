/*
 
Enlaces de ejemplos: https://docs.microsoft.com/es-es/dotnet/csharp/programming-guide/file-system/how-to-write-to-a-text-file
 
*/


using Beca.BooksLibrary.Entities;
using Beca.BooksLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Beca.BooksLibrary.Win
{
    public partial class frmMain : FormBase
    {
        
        #region Global variables

        /// <summary>
        /// Books library.
        /// </summary>
        private List<Book> MyBooksLibrary;

        #endregion Global variables

        #region Constructor

        /// <summary>
        /// Constructor.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
            base.InitializeForm();
        }

        #endregion

        #region Events

        /// <summary>
        /// Form load.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void frmMain_Load(object sender, EventArgs e)
        {  
            Initialize();
        }

        /// <summary>
        /// Load file button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadFile();
        }

        /// <summary>
        /// Add book button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBook();
        }

        /// <summary>
        /// Save file button click event.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">Event arguments.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        #endregion Events

        #region Private methods

        /// <summary>
        /// Initialize form.
        /// </summary>
        private void Initialize()
        {
            MyBooksLibrary = new List<Book>();

            grdBooks.DataSource = MyBooksLibrary;

            // Set not editable columns
            foreach (DataGridViewColumn column in grdBooks.Columns)
            {
                column.ReadOnly = true;
            }

            // Set width grid columns
            grdBooks.Columns["Tittle"].FillWeight = 45;
            grdBooks.Columns["Author"].FillWeight = 45;
            grdBooks.Columns["Pages"].FillWeight = 10;

            // Disable save button
            btnSave.Enabled = false;     

        }

        /// <summary>
        /// Load file.
        /// </summary>
        private void LoadFile()
        {
            FileManager fileManager = new FileManager();

            List<Book> booksFromFile = new List<Book>();

            fileManager.LoadFile(out booksFromFile);

            foreach(Book book in booksFromFile)
            {
                // Check if the new book already exists
                if (!MyBooksLibrary.Contains(book))
                {
                    MyBooksLibrary.Add(book);
                }
            }

            RefreshGrid();

            MessageBox.Show("'Load books' process finished.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
        }

        /// <summary>
        /// Save file.
        /// </summary>
        private void SaveFile()
        {
            FileManager fileManager = new FileManager();

            fileManager.SaveFile(MyBooksLibrary);
        }

        /// <summary>
        /// Add book to library.
        /// </summary>
        private void AddBook()
        {
            frmAddBook frmAdd = new frmAddBook();

            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                // Add the new book to the library
                if (frmAdd.Book != null)
                {
                    // Check if the new book already exists
                    if (!MyBooksLibrary.Contains(frmAdd.Book))
                    {
                        MyBooksLibrary.Add(frmAdd.Book);

                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("The book already exists.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// <summary>
        /// Refresh grid data.
        /// </summary>
        private void RefreshGrid()
        {
            if (MyBooksLibrary != null)
            {
                // Order list
                MyBooksLibrary = MyBooksLibrary.OrderBy(x => x.Tittle).ToList();

                // Check enabling Save button
                btnSave.Enabled = (MyBooksLibrary.Count > 0);
            }

            grdBooks.DataSource = null;
            grdBooks.DataSource = MyBooksLibrary;
                        
        }

        #endregion Private methods
    }
}
