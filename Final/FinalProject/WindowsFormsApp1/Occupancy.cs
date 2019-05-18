using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Occupancy
    {
        public string ClientID;
        public string RoomNumber;
        public static Queue<Room> vacancies;

        public Occupancy(string v1, string v2)
        {
            this.ClientID = v1;
            this.RoomNumber = v2;
        }
        public override string ToString()
        {
            return $"{ClientID}\t{RoomNumber}";
        }
        public string Out()
        {
            return $"{ClientID}:{RoomNumber}";
        }


        
    }
}
