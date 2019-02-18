using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicals
{
    public class Broom : Vehicle, ISaveTheEnvironment
    {
        public Broom() { }

        public Broom(int n, string f, string c)
        {
            NumberOfWheels = n;
            FuelType = f;
            Color = c;
        }




        public override void Move()
        {
            Console.WriteLine("Broom flies with magic!");
        }

        public void SaveEnvironment()
        {
            Console.WriteLine("Sweep up trash!");
        }

        public override void Start()
        {
            Console.WriteLine("Eye of Newt required!");
        }
    }
}
