using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicals
{
    public class FunctionalStuff
    {
        public List<ISaveTheEnvironment> Vehicles { get; set; }
        


        public FunctionalStuff(List<ISaveTheEnvironment> v)
        {
            Vehicles = v;
        }
        
        //call the save the environment method on items that save it.
        public void SaveEnvironments()
        {
            foreach(var broom in Vehicles)
            {
                broom.SaveEnvironment();
            }
        }

        






    }
}
