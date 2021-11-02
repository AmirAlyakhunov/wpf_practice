using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMath
{
    public class Geometry
    {
        public int RectangleArea(int a, int b)
        {
            if (a <= 0) throw new ArgumentException("a <= 0", "a");
            if (b <= 0) throw new ArgumentException("b <= 0", "b");
            return a * b;
        }
    }
}
