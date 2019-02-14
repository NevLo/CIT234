using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicals
{
    public class Car : Vehicle
    {
        public string Model { get; set; }


        public Car()
        {

        }


        public override void Move()
        {
            Console.WriteLine("VROOOOOOOOOOOOOOOOOOOOOOOM");
        }

        public override void Start()
        {
            Console.WriteLine("RUMBLE RUMBLE rumble rumble rumble");
        }
    }
}
