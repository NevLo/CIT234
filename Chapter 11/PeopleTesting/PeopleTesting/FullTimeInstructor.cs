using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTesting
{
    class FullTimeInstructor : Instructor

    {
       public FullTimeInstructor()
        {

        }
        public void SetMembers(string fn, string ln, DateTime bd)
        {
            FirstName = fn;
            LastName = ln;
            BirthDate = bd;
        }
        protected override void SetUsername(string u)
        {
            userName = u;
        }
        public void SetItDamnYou(string u)
        {
            SetUsername(u);
        }

        
    }
}
