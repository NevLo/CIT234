using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Occupancy
    {
        string ClientID;
        string RoomNumber;
        

        public Occupancy(string v1, string v2)
        {
            this.ClientID = v1;
            this.RoomNumber = v2;
        }
    }
}
