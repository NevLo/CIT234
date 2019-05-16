using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class BasicRoom : Room
    {
        bool Smoking;

        public BasicRoom(string room, bool bal, bool dfr, int numBeds, bool sm)
        {
            RoomNumber = room;
            Balcony = bal;
            DownForRepair = dfr;
            NumberOfBeds = numBeds;
            Smoking = sm;
        }
        public override string ToString()
        {
            return $"{RoomNumber}\t{Balcony}\t{DownForRepair}\t{NumberOfBeds}\t{Smoking}";
        }


        public override string Out()
        {
            return $"{RoomNumber}.{((Balcony) ? 'T' : 'F')}.{((DownForRepair) ? 'T' : 'F')}.{NumberOfBeds}:B:{((Smoking) ? 'T' : 'F')}";
        }

    }
}
