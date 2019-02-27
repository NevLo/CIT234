using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Cheeta ch1 = new Cheeta();
            Joey kanga = new Joey();
            Otter oscar = new Otter();

            ch1.HowIEat();
            ch1.Jump();

            kanga.HowIEat();
            kanga.Jump();

            oscar.HowIEat();
            oscar.Jump();
        }
    }
}
