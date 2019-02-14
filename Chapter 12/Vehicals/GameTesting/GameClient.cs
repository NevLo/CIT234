using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTesting
{
    class GameClient
    {
        public static void Main(string[] args)
        {
            List<GameObject> objs = new List<GameObject>
            {
                new Ship(),
                new Bomb()
            };

            foreach (var obj in objs)
            {
                if(obj is Ship)
                {
                    ((Ship)obj).BlowUp(23.4);
                    ((Ship)obj).Shoot();
                    var temp = ((Ship)obj).StealLife();
                    Console.WriteLine($"You stole {temp}");
                }
                if(obj is Bomb)
                {
                    ((Bomb)obj).BlowUp(46.8);
                }
            }



        }
    }
}
