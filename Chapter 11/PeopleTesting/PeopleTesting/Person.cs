using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTesting
{
    public class Person
    {
        protected string FirstName { get; set; }
        protected string LastName { get; set; }
        protected DateTime BirthDate { get; set; }
        protected string userName;


        public Person() { }

        public Person(string fn, string ln, DateTime bd)
        {
            BirthDate = bd;
            FirstName = fn;
            LastName = ln;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate;
        }

        protected virtual void SetUsername(string u)
        {
            if (!u.Equals("dork"))
            {
                userName = u;
            }
            else
            {
                userName = "NO! CALL I.T.!";
            }
        }

        public virtual void displayUsername()
        {
            Console.WriteLine(userName);
        }


    }
}
