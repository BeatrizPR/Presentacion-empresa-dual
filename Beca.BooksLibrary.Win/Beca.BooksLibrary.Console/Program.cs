using Beca.BooksLibrary.Entities;
using Beca.BooksLibrary.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beca.BooksLibrary.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = @"C:\Users\j.cintrano.montes\Documents\Visual Studio 2015\Projects\Beca.BooksLibrary.Win\books.txt";

            string target = @"C:\Users\j.cintrano.montes\Documents\Visual Studio 2015\Projects\Beca.BooksLibrary.Win\savetest.txt";

            List<Book> booksLibrary;

            FileManager fileManager = new FileManager();

            fileManager.LoadFile(source, out booksLibrary);

            fileManager.SaveFile(target, booksLibrary);

        }
    }
}
