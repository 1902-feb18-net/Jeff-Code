using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsAndLINQ
{
    public static class ListExtension
    {
        public static bool Empty<T>(this List<T> list)
        {
            return list.Count == 0;
        }

        public static int Pow(this int a, int b)
        {
            if(b < 0)
            {
                throw new ArgumentException("exponent must be nonneagative",nameof(b))
                                                              // "nameof" is good when you want a string of whatever variable 
            }

            if(b == 0)
            {
                return 1;
            }
            int result;

            for(result = a; b > 0; b--)
            {
                result *= a;
            }
            

        }
    }
}
