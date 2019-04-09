using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClient
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMale { get; set; }

        public Person()
        {
            Name = "";
            Age = 0;
            IsMale = true;
        }
        public Person(string n, int a, bool m)
        {
            Name = n;
            Age = a;
            IsMale = m;
        }

        public string getNickName()
        {
            string nick = "";
            int year = DateTime.Today.Year;
            int birthYear = year - Age;
            if(birthYear > 2000)
            {
                nick = "Broski_" + Name;
            }
            else if(birthYear > 1990)
            {
                nick = "Homie_" + Name;
            }else if(birthYear > 1980)
            {
                nick = "Dude_" + Name;
            }
            else
            {
                nick = "Sir_" + Name;
            }

            return nick;
        }

        public int getBirthYear()
        {
            return DateTime.Now.Year - Age;
        }

        public int[] getShirtColor()
        {
            Random rand = new Random();
            int x = rand.Next(256);
            int y = rand.Next(256);
            int z = rand.Next(256);


            int[] shirtColor = {x,y,z};


            return shirtColor;
        }
        








    }
}
