using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTesting
{
    public class Student : Person
    {
        public float GPA { get; set; }
        public int StudentIdNumber { get; set; }
        public bool IsVeteran { get; set; }


        public Student(string fn, string ln, DateTime bd)
            : base(fn, ln, bd)
        {

        }

        public override bool Equals(object obj)
        {
            if (obj is Student stu)
            {
                return (
                    this.FirstName == stu.FirstName
                    && this.LastName == stu.LastName
                    && this.BirthDate == stu.BirthDate
                  );
            }
            return false;
        }



    }
}
