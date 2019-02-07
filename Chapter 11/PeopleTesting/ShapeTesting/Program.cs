using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Square sq1 = new Square();
            sq1.SideLength = 10;
            sq1.CalcArea();
            sq1.displayArea();
        }
    }
}
