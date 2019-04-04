using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_List
{
    public class Business : Donation
    {
        public Business()
        {
            Type = "Business Donation";
        }
        public override decimal GiveMoney()
        {
            Random rand = new Random();
            return rand.Next(10) * 50.00M;
        }
    }
}
