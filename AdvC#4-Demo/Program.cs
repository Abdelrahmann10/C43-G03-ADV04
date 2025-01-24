using System.Xml;

namespace AdvC_4_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Intro To Delegate
            // Delegate is a C# language feature
            // Has 2 usage
            // 1- Functional Programming
            // 2- Event - Driven Programming
            #endregion

            #region Example 01
            //int Result = StringFunctions.GetCountOfUpperChars;
            // step 01 : Declare reference from the delegate
            //StringFuncyDelegate Ref;
            // step 02 : Initialize the delegate Ref [ Pointer to func ]
            //Ref = new StringFuncyDelegate(StringFunctions.GetCountOfUpperChars);
            //Ref = StringFunctions.GetCountOfUpperChars; // Syntax Sugar
            //Step 03 : Use delegate Ref [ Call Method ]
            //int Result = Ref.Invoke("Abdelrahman Sorour");
            //Console.WriteLine($"The Result is {Result}");
            #endregion

            #region Example 02
            #region Without Generics
            //int[] Numbers = { 4, 1, 3, 2, 6,5 };
            ////SortingAlgorithms.BubbleSortAsc(Numbers);
            ////SortingAlgorithms.BubbleSortDesc(Numbers);
            ////SortingTyoesFuncyDelegate sortingTyoesFuncyDelegate = Sorting_Types.CompareLess;
            //SortingTyoesFuncyDelegate sortingTyoesFuncyDelegate = default;
            //SortingAlgorithms.BubbleSort(Numbers, Sorting_Types.CompareGrt);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion

            #region With Generics
            //string[] Names = { "Abdelrahman", "Ali", "Omar", "Rana", "Mai" };
            //SortingTypesFuncyDelegate<string, string, bool> sortingTypesFuncyDelegate = Sorting_Types.SortStringAsc;
            //SortingAlgorithms<string>.BubbleSort(Names, sortingTypesFuncyDelegate);
            //foreach(string name in Names)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion
            #endregion

            #region Example 03

            #region Without Generics
            //List<int> Numbers = Enumerable.Range(0,100).ToList();
            //List<int> OddNumbers = Example03Class.FindOddNumbers(Numbers);
            //foreach(int number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////---------------------------------
            //List<int> EvenNumbers = Example03Class.FindEvenNumbers(Numbers);
            //foreach (int number in EvenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////----------------------------------
            //List<int> Numbers = Enumerable.Range(0, 100).ToList();
            //ConditionFuncDelegate conditionFuncDelegate01 = ConditionFunc.CheckOdd;
            //List<int> OddNumbers = Example03Class.FindNumbers(Numbers, conditionFuncDelegate01);
            //foreach (int number in OddNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            ////----------------------------------
            //Console.WriteLine("----------------------");
            //ConditionFuncDelegate conditionFuncDelegate02 = ConditionFunc.CheckEven;
            //List<int> EvenNumbers = Example03Class.FindNumbers(Numbers, conditionFuncDelegate02);
            //foreach (int number in EvenNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region With Generics
            //List<string> Names = new List<string> { "Abdelrahman", "Ali", "Mohamed", "Asmaa"};
            //ConditionFuncDelegate<string> conditionFuncDelegate = ConditionFunc.CheckLength;
            //List<string> NamesHaveLengthMoreThan4 = Example03Class<string>.FindElements(Names, conditionFuncDelegate);
            //foreach(string name in NamesHaveLengthMoreThan4)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #endregion

            #region Example 03

            #endregion

        }
    }
}