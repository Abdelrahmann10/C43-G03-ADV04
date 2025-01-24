using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_2_Assignment
{
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList, BookFuncDelegate fptr)
        {
            foreach (Book book in bList)
            {
                Console.WriteLine(fptr(book));
            }
        }

        public static void ProcessBooks<T>(List<Book> list, Func<Book, T> FuncgetAuthors)
        {
            foreach (Book book in list)
            {
                Console.WriteLine(FuncgetAuthors(book));
            }
        }
    }
}
