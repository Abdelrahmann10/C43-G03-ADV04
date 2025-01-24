using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4_Demo
{
    internal class Sorting_Types
    {
        public static bool SortStringAsc(string X, string Y) { return X?.Length > Y?.Length; }
        public static bool SortStringDesc(string X, string Y) { return X?.Length < Y?.Length; }
        public static bool CompareGrt(int X, int Y) { return X > Y; } //Sort Asc
        public static bool CompareLess(int X, int Y) { return X < Y; } //Sort Desc
    }
}
