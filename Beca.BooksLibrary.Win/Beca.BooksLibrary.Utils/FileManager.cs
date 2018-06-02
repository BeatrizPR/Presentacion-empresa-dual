using Beca.BooksLibrary.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Beca.BooksLibrary.Utils
{
    public class FileManager
    {
        #region Constants

        /// <summary>
        /// Constant for tittle column in file.
        /// </summary>
        private const int FILE_COLUMN_TITTLE = 0;

        /// <summary>
        /// Constant for author column in file.
        /// </summary>
        private const int FILE_COLUMN_AUTHOR = 1;

        /// <summary>
        /// Constant for pages column in file.
        /// </summary>
        private const int FILE_COLUMN_PAGES = 2;

        #endregion

        /// <summary>
        /// Load file and return a books library object.
        /// </summary>
        /// <param name="booksLibrary">Books library.</param>
        /// <returns>Error True/False.</returns>
        public bool LoadFile(out List<Book> booksLibrary)
        {
            bool result = false;

            booksLibrary = new List<Book>();

            // Open file dialog to select file
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Title = "Open books file";
            fileDialog.Filter = "Text Files (.txt)|*.txt";

            DialogResult diagResult = fileDialog.ShowDialog();

            if ((diagResult == DialogResult.OK) && (!string.IsNullOrEmpty(fileDialog.FileName)))
            {
                string fileName = fileDialog.FileName;

                // Read file
                this.LoadFile(fileName, out booksLibrary);                
            }

            return result;
        }

        /// <summary>
        /// Load file and return a books library object.
        /// </summary>
        /// <param name="fileFullName">File full name.</param>
        /// <param name="booksLibrary">Books library.</param>
        /// <returns>Error True/False.</returns>
        public bool LoadFile(string fileFullName, out List<Book> booksLibrary)
        {
            bool result = false;

            booksLibrary = new List<Book>();

            // Read file

            try
            {
                foreach (string line in File.ReadLines(fileFullName))
                {
                    // Get data
                    string[] data = line.Split('|');

                    if ((data != null) && (data.Length > 0))
                    {
                        Book book = new Book();
                        book.Tittle = data[FILE_COLUMN_TITTLE];
                        book.Author = data[FILE_COLUMN_AUTHOR];
                        book.Pages = int.Parse(data[FILE_COLUMN_PAGES]);

                        booksLibrary.Add(book);
                    }
                }

                result = true;
            }
            catch (System.IO.FileNotFoundException ex)
            {
                booksLibrary.Clear();

                MessageBox.Show("There was an error with the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                booksLibrary.Clear();

                MessageBox.Show("The file could not be read:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return result;
        }

        /// <summary>
        /// Save library to a file.
        /// </summary>
        /// <param name="booksLibrary">Books library.</param>
        /// <returns>Error True/False.</returns>
        public bool SaveFile(List<Book> booksLibrary)
        {
            bool result = false;

            SaveFileDialog fileDialog = new SaveFileDialog();

            fileDialog.Title = "Save books to file";
            fileDialog.Filter = "Text Files (.txt)|*.txt";

            DialogResult diagResult = fileDialog.ShowDialog();

            if ((diagResult == DialogResult.OK) && (!string.IsNullOrEmpty(fileDialog.FileName)))
            {
                string fileName = fileDialog.FileName;

                SaveFile(fileName, booksLibrary);
            }

            return result;
        }

        /// <summary>
        /// Save library to a file.
        /// </summary>
        /// <param name="fileFullName">File full name.</param>
        /// <param name="booksLibrary">Books library.</param>
        /// <returns>Error True/False.</returns>
        public bool SaveFile(string fileFullName, List<Book> booksLibrary)
        {
            bool result = false;

            // Save file
            try
            {
                using (StreamWriter sw = new StreamWriter(fileFullName))
                {

                    foreach (Book book in booksLibrary)
                    {
                        // Write "Tittle|Author|Pages"
                        // Note: Join method has the separator string as first parameter. 
                        // Second parameter is a params type and must be the last input parameter.
                        string line = string.Join("|", book.Tittle, book.Author, book.Pages.ToString());

                        sw.WriteLine(line);
                    }
                }

                result = true;

            }
            catch (System.IO.FileNotFoundException ex)
            {
                MessageBox.Show("There was an error with the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be read:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            return result;
        }

    }
}
