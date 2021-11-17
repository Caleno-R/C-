using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class ByValByRef
    {
        public static void alterValues(ref int x, ref int y, ref int z) //By Reference
        //public static void alterValues(ref int x, ref int y, ref int z) By Value
        {
            x = x + Convert.ToInt32(x * 0.1);
            y = y * 100;
            z = z - 50;

        }
    }
}
