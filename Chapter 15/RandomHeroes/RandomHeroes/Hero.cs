using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomHeroes
{
    class Hero
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int HitPoints { get; set; }
        public string Ability { get; set; }
        public bool IsFemale { get; set; }
        public List<string> Weaknesses { get; set; }
        private string[] fn = { "amaani", "titania", "galigus", "yorgk", "gedmit" };
        private string[] ln = { "Heathcliff", "goldheart", "dragonstone", "galivaant", "sheldbranst"};
        private string[] ab = { "Invisibilty","Strength","Agility","Endurance","Defense"};

        public Hero(Random rand)
        {
            var r = rand.Next(5);
            FName = fn[r];
            r = rand.Next(5);
            LName = ln[r];
            r = rand.Next(5);
            Ability = ab[r];
            HitPoints = r * rand.Next(10) + 1;
            Weaknesses = new List<string>();
        }
        

        public void AddWeaknesses(List<string> Weaknessess)
        {
            this.Weaknesses = Weaknessess;
        }

        public void CheckGender(bool isFemale)
        {
            this.IsFemale = isFemale;
        }

        public string GetHeroInfo()
        {
            string res = FName + " " + LName;
            res += $" - {Ability} - {HitPoints} HP";
            res += (IsFemale? " - Female" : " - Male");
            res += "\n Weaknesses | ";
            if (Weaknesses.Count > 0)
            {
                foreach(var w in Weaknesses)
                {
                    res += w + ", ";
                }
            }
            else
            {
                res += "None.";
            }
            return res;
        }


    }
}
