using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicals
{
    public abstract class Vehicle : ISaveTheEnvironment
    {
        public int NumberOfWheels { get; set; }
        public string FuelType { get; set; }
        public string Color { get; set; }

        public abstract void Move();
        public void DoSomething()
        {
            Console.WriteLine("Does Something");
        }
        public void SaveEnvironment()
        {
            Console.WriteLine("Sweep up Trash!");
        }

        public abstract void Start();


    }
}
