using System;

namespace Beca.BooksLibrary.Entities
{
    /// <summary>
    /// Book.
    /// </summary>
    public class Book : IEquatable<Book>
    {
        /// <summary>
        /// Tittle.
        /// </summary>
        public string Tittle { get; set; }

        /// <summary>
        /// Author
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Pages.
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// Equals.
        /// </summary>
        /// <param name="book">Book.</param>
        /// <returns>True/False.</returns>
        public bool Equals(Book book)
        {
            if (book == null)
            {
                return false;
            }
            else
            {
                return (this.Tittle.Equals(book.Tittle)) && (this.Author.Equals(book.Author)) && (this.Pages == book.Pages);
            }
        }
    }
}
