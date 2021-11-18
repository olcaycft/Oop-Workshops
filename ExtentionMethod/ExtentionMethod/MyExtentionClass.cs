using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethod
{
     static class MyExtentionClass
    {
        public static bool Ciftmi(this int a)
        {
            if (a%2==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
