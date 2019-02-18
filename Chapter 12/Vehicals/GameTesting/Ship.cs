using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting
{
    public class Ship : GameObject,IShoot, IBlowUp, IStealYourLife
    {
        public void BlowUp(double radius)
        {
            Console.WriteLine($"Ship blew up in radius of {radius}");
        }

        public void Shoot()
        {
            Console.WriteLine($"Bang!");
        }

        public int StealLife()
        {
            return 13;
        }
    }
}
