using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Test
{
    class SegaDreamCast : Console
    {
        public byte MemoryUsed { get; set; }

        public SegaDreamCast()
        {
            MemoryUsed = 20; // Gotta load up the base software yo
        }

        public bool MemoryLeak()
        {
            return MemoryUsed >= Byte.MaxValue - 20;
            
        }
        public override void MakeNewUserName()
        {
            UserName = "Steve";
        }
        public override double GetPrice()
        {
            return 69.99;
        }




    }
}
