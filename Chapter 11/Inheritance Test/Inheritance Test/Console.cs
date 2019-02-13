using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Test
{
    class Console
    {
        public static int NumberOfConsoles;
        public String ConsoleID { get; set; }
        public int MaxPlayers { get; set; }
        public String UserName { get; set; }

        public virtual void MakeNewUserName()
        {
            Random rand = new Random();

            int digits = (int) Math.Floor(rand.NextDouble() * 1000.00);
            UserName = "User#" + digits;
        }

        public Console()
        {
            NumberOfConsoles++;
            ConsoleID = NumberOfConsoles.ToString();
        }

        public virtual double GetPrice() { return 0; }




    }
}
