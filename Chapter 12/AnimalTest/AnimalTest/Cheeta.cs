using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Cheeta : Animal, IEatFood
    {
        public void HowIEat()
        {
            Console.WriteLine("Very Fast Nommings");
        }

        public override void Jump()
        {
            Console.WriteLine("Roar!");
        }
    }
}
