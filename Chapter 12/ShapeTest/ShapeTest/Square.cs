using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Square : Shape, IChangeColor
    {
        double SideLength { get; set; }
        string Color { get; set; }

        public Square(double SideLength)
        {
            this.SideLength = SideLength;
            this.Color = "White";
        }

        public void ChangeColor(string Color)
        {
            string temp = this.Color;
            this.Color = Color;
            Console.WriteLine($"Color changed from {temp} to {Color}");
        }

        public override void GetArea()
        {
            Console.WriteLine($"Area: S^2 = {SideLength} ^ 2 = {SideLength * SideLength}");
        }
    }
}
