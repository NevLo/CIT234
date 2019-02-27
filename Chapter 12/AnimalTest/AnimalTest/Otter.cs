using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Otter : Animal, IEatFood
    {
        public void HowIEat()
        {
            Console.WriteLine("Nomming on some sticks");
        }

        public override void Jump()
        {
            Console.WriteLine("Otters dont jump, they swim!");
        }
    }
}
