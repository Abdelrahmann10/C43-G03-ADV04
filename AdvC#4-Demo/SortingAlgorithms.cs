using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4_Demo
{
    //Step 0 : Delare delegate
    public delegate TResult SortingTypesFuncyDelegate<in T1,in T2, out TResult>(T1 aarg01, T2 arg02);
    internal class SortingAlgorithms<T>
    {
        #region For Test
        //public static void BubbleSortAsc(int[] array)
        //{
        //    if(array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++) 
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++) 
        //            {
        //                if(array[j] > array[j+1])
        //                {
        //                    Swap(ref array[j], ref array[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //}
        //public static void BubbleSortDesc(int[] array)
        //{
        //    if (array is not null)
        //    {
        //        for (int i = 0; i < array.Length; i++)
        //        {
        //            for (int j = 0; j < array.Length - i - 1; j++)
        //            {
        //                if (array[j] < array[j + 1])
        //                {
        //                    Swap(ref array[j], ref array[j + 1]);
        //                }
        //            }
        //        }
        //    }
        //} 
        #endregion

        public static void BubbleSort(T[] array, SortingTypesFuncyDelegate<T,T,bool> sortingTypesFunc)
        {
            if (array is not null && sortingTypesFunc is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        //if (array[j] > array[j + 1])
                        if (sortingTypesFunc.Invoke(array[j], array[j + 1]))
                        {
                            Swap(ref array[j], ref array[j + 1]);
                        }
                    }
                }
            }
        }
        private static void Swap (ref T X, ref T Y)
        {
            T Team = X;
            X = Y;
            Y = Team;
        }
    }
}
