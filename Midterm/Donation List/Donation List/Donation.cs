using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation_List
{
    public abstract class Donation : IHasANickName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Type { get; set; }
        public abstract decimal GiveMoney();



        public string GiveANickName(string first, string last)
        {
            Random rand = new Random();
            string nickName = "";
            
            int x = rand.Next(10);
            int y = rand.Next(26);

            nickName = first + x.ToString() + '_' + last + y.ToString();

            return nickName;
        }
    }
}
