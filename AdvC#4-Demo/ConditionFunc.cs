using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4_Demo
{
    internal class ConditionFunc
    {
        public static bool CheckOdd(int Number) {  return Number % 2 == 1 ; }
        public static bool CheckEven(int Number) {  return Number % 2 == 0 ; }
        public static bool CheckLength(string Name) {  return Name?.Length > 4; }
    }
}
