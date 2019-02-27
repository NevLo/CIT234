using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle(3);
            Triangle tri = new Triangle(6, 3);
            Square sqr = new Square(3);

            cir.ChangeColor("red");
            cir.GetArea();
            Console.WriteLine();
            tri.ChangeColor("cyan");
            tri.GetArea();
            Console.WriteLine();
            sqr.ChangeColor("black");
            sqr.GetArea();
        }
    }
}
