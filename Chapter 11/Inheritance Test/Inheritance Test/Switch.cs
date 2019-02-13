using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Test
{
    class Switch : Console
    {
        public int NumJoyCons { get; set; }

        public Switch()
        {
            NumJoyCons = 2;
        }

        public void AddJoyCons()
        {
            NumJoyCons += 2;
        }
        public override double GetPrice()
        {
            return 299.99;
        }
        public override void MakeNewUserName()
        {
            UserName = "PLEASEADDWALUIGITOSMASHSAKURAI";
        }




    }
}
