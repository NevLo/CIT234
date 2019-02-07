using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTesting
{
    public class Instructor : Person
    {


        public string OfficeHours { get; set; }

        public Instructor() { }
        public Instructor(string fn, string ln, DateTime bd)
            : base(fn, ln, bd)
        {

        }
        protected override void SetUsername(string u)
        {
            base.SetUsername(u);
        }





    }
}

