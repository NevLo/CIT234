using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleTesting
{
    public class PeopleTesting
    {
        static void Main(string[] args)
        {


            Student stu1 = new Student("Bob", "Smith", 
                new DateTime(1980, 12, 7));

            Student stu2 = new Student("Bob", "Smith",
                new DateTime(1980, 12, 7));
            Console.WriteLine(stu1.Equals(stu2));
            FullTimeInstructor ins1 = 
                new FullTimeInstructor();
            ins1.SetMembers("Topher", "Reynolds", new DateTime(1976,2,14));
            Person p = new Person("", "", new DateTime());

            ins1.SetItDamnYou("dork");
            ins1.displayUsername();
            Console.WriteLine(stu1.ToString());

            Console.WriteLine(ins1.ToString());




        }
    }
}
