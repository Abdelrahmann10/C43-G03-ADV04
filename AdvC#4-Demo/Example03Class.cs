using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4_Demo
{
    public delegate bool ConditionFuncDelegate<in T>(T number);
    internal class Example03Class<T>
    {
        public static List<int> FindOddNumbers(List<int> Numbers)
        {
            List<int> Result = new List<int>();
            if(Numbers is not null)
            {
                for(int i=0;i<Numbers.Count; i++)
                {
                    if(Numbers[i]%2==1)
                    {
                        Result.Add(Numbers[i]);
                    }
                }
            }
            return Result;
        }
        public static List<int> FindEvenNumbers(List<int> Numbers)
        {
            List<int> Result = new List<int>();
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    if (Numbers[i] % 2 == 0)
                    {
                        Result.Add(Numbers[i]);
                    }
                }
            }
            return Result;
        }
        public static List<int> FindNumbersDivisableBy7(List<int> Numbers)
        {
            List<int> Result = new List<int>();
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    if (Numbers[i] % 7 == 0)
                    {
                        Result.Add(Numbers[i]);
                    }
                }
            }
            return Result;
        }
        public static List<int> FindNumbersDivisableBy10(List<int> Numbers)
        {
            List<int> Result = new List<int>();
            if (Numbers is not null)
            {
                for (int i = 0; i < Numbers.Count; i++)
                {
                    if (Numbers[i] % 10 == 0)
                    {
                        Result.Add(Numbers[i]);
                    }
                }
            }
            return Result;
        }
        public static List<T> FindElements(List<T> elements, ConditionFuncDelegate<T> conditionFuncDelegate)
        {
            List<T> Result = new List<T>();
            if (elements is not null)
            {
                for (int i = 0; i < elements.Count; i++)
                {
                    //if (Numbers[i] % 10 == 0)
                    if (conditionFuncDelegate.Invoke(elements[i]))
                    {
                        Result.Add(elements[i]);
                    }
                }
            }
            return Result;
        }



    }
}
