using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Client
    {
        public static int numClients = 0;
        public string ID;
        public string FirstName;
        public string LastName;
        public string Address;
        public long PhoneNumber;
        List<string> DoorPrizes;

        public Client()
        {
            ID = "";
            FirstName = "";
            LastName = "";
            Address = "";
            PhoneNumber = -1;
            DoorPrizes = new List<string>();
            numClients += 1;
        }
        public Client(string fn, string ln, string ad, long num)
        {
            ID = $"CL{ ClientNumToString() }";
            FirstName = fn;
            LastName = ln;
            Address = ad;
            PhoneNumber = num;
            DoorPrizes = new List<string>();
            numClients += 1;
        }
        public Client(string id, string fn, string ln, string ad, long num, string[] doorPrizes)
        {
            ID = id;
            FirstName = fn;
            LastName = ln;
            Address = ad;
            PhoneNumber = num;
            DoorPrizes = new List<string>();
            foreach (string s in doorPrizes)
            {
                DoorPrizes.Add(s);
            }
            numClients += 1;
        }

        public string ClientNumToString()
        {
            string number = numClients.ToString();
            if (number.Length == 1) number = "000" + number;
            if (number.Length == 2) number = "00" + number;
            if (number.Length == 3) number = "0" + number;
            return number;
        }
        public override string ToString()
        {
            return $"{ID}\t{FirstName}\t{LastName}\t{Address}\t{PhoneNumber}";
        }

        public object displayDoorPrizes()
        {
            string dp = "";
            foreach (var s in DoorPrizes)
            {
                dp += s + "  ";
            }
            return dp;
        }

        public string Out()
        {
            string outString = $"{ID}.{FirstName}.{LastName}.{Address}.{PhoneNumber}:";
            foreach(var v in DoorPrizes)
            {
                outString += v + ".";
            }
            
            return outString;
        }
    }
}
