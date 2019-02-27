using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Triangle : Shape, IChangeColor
    {
        double Base { get; set; }
        double Height { get; set; }
        string Color { get; set; }

        public Triangle(double Base, double Height)
        {
            this.Base = Base;
            this.Height = Height;
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
            Console.WriteLine($"Area: 1/2 * Base * Height = 1/2 * {Base} * {Height} = {(Base * Height)/2}");
        }
    }
}
