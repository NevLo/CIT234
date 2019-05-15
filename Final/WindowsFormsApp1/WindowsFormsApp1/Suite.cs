using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Suite : Room
    {
        int NumberOfRooms;

        public Suite(string room, bool bal, bool dfr, int numBeds, int numRooms)
        {
            RoomNumber = room;
            Balcony = bal;
            DownForRepair = dfr;
            NumberOfBeds = numBeds;
            NumberOfRooms = numRooms;
        }
        public override string ToString()
        {
            return $"{RoomNumber}\t{Balcony}\t{DownForRepair}\t{NumberOfBeds}\t{NumberOfRooms}";
        }
    }
}
