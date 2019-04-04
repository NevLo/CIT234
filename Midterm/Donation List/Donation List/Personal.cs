using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_List
{
    public class Personal : Donation
    {
        public Personal()
        {
            Type = "Personal Donation";
        }
        public override decimal GiveMoney()
        {
            Random rand = new Random();
            return rand.Next(10) * 100.00M;
        }
    }
}
