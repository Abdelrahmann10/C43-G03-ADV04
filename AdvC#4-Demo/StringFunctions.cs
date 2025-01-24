using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvC_4_Demo
{
    // Step 0 : Delegate declaration
    public delegate int StringFuncyDelegate(string str);
    /* New Delegate(Class), the reference from this delegate can 
     refere to function or more than function(Pointer to function) */
    // These functions may be class member func or object member func
    // These functions must be the same signature of the delegate
    // Reradless functions access modifier or name of the functionm

    internal class StringFunctions
    {
        public static int GetCountOfUpperChars(string Name)
        {
            int Count = 0;
            if (Name is not null)
            {
                for (int i = 0; i < Name.Length; i++)
                {
                    if (char.IsUpper(Name[i]))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }
    }
}
