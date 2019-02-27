using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public class Joey : Animal, IEatFood
    {
        public void HowIEat()
        {
            Console.WriteLine("Nom Mate");
        }

        public override void Jump()
        {
            Console.WriteLine("Just hoppin to the Servo to grab some Petrol and  Mackas"); ;
        }
    }
}
