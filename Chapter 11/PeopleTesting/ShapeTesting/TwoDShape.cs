using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTesting
{
    public abstract class TwoDShape : Shape
    {
        public double Area { get; set; }
        
       

        public abstract void CalcArea();

        public void displayArea()
        {
            Console.WriteLine("Area is {0}", Area);
        }
    }

}
