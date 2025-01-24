namespace AdvC_2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Book> list = new List<Book>()

            {
                new Book( "307"   ," Work Under Pressure "   ,new String[]{" Abdelrahman Sorour   " ,"   3booood   "} , DateTime.Today , 400 ),
                new Book( "555"   ," Leo Messi "   ,new String[]{" leo Messi"," Leo "} , DateTime.Now   , 500 ),

            };

            BookFuncDelegate FuncGetTittle = BookFunction.GetTitle;
            LibraryEngine.ProcessBooks(list, FuncGetTittle);
            Console.WriteLine();



            Func<Book, string> FuncgetAuthors = BookFunction.GetAuthors;
            LibraryEngine.ProcessBooks(list, FuncgetAuthors);
            Console.WriteLine();


            BookFuncDelegate FuncGetPrice = BookFunction.GetPrice;
            LibraryEngine.ProcessBooks(list, FuncGetPrice);
            Console.WriteLine();


        }
    }
}
