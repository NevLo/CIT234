using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting
{
    class Bomb : GameObject, IBlowUp
    {
        public void BlowUp(double radius)
        {
            Console.WriteLine($"You blew up with radius: {radius}");
        }
    }
}
