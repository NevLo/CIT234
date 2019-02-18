using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicals
{
    class VehicleClient
    {
        static void Main(string[] args)
        {

            //Create lists
            var Vehicles = new List<ISaveTheEnvironment>();
            //Create vehicles
            Broom broomiemcbroomface = new Broom(0, "Magic", "Broomered");
            Car car = new Car();
            var boat = new Boat();
            Vehicles.Add(boat);



            //Add a broom to the list
            Vehicles.Add(broomiemcbroomface);
            Vehicles.Add(new Broom(1,"Magic", "Black"));
            //Add a car to the list
            Vehicles.Add(car);
            //create a functional stuff
            var funcStuff = new FunctionalStuff(Vehicles);
            funcStuff.SaveEnvironments();


            //call inherited methods
            broomiemcbroomface.Start();
            broomiemcbroomface.Move();
            car.Start();
            car.Move();


        }
    }
}
