using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    public class Circle : Shape, IChangeColor
    {
        public double Radius { get; set; }
        public string Color { get; set; }

        public Circle(double Radius)
        {
            this.Radius = Radius;
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
            Console.WriteLine($"Area = PI * R^2 = {Math.PI} * {Radius}^2 = {Math.PI * Radius * Radius}");
        }
    }
}
