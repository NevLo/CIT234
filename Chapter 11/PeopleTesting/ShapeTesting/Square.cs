using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTesting
{
    class Square : TwoDShape
    {
        public double SideLength { get; set; }

        public override void CalcArea()
        {
           Area = Math.Pow(SideLength,  2.0);
        }
        
    }
}
