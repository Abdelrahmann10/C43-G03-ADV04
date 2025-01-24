using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_2_Assignment
{
    public delegate string BookFuncDelegate(Book book);

    public class BookFunction
    {
        public static string GetTitle(Book B)
        {
            return $"Tittle : {B.Title} ";
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(" , ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return B.Price.ToString();
        }
    }
}
