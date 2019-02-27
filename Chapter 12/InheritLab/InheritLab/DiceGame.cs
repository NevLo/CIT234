using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritLab
{
    public class DiceGame : Game
    {
        private int numberOfDice;
        public int NumberOfDice
        {
            get
            {
                return numberOfDice;
            }
            set
            {
                if (value < 1000 && value > 0)
                {
                    numberOfDice = value;
                }
            }
        }
        private int numberOfPlayers;
        public int NumberOfPlayers
        {
            get
            {
                return numberOfPlayers;
            }
            set
            {
                if(value > 0 && value <= 9)
                {
                    numberOfPlayers = value;
                }
            }
        }


        public DiceGame(  int numPlayers, int numDices, string name)
        {
            NumberOfDice = numDices;
            NumberOfPlayers = numPlayers;
            Name = name;
        }

        public override void EndGame()
        {
            Console.WriteLine($"The game {Name} is over!");
        }

        public override void StartGame()
        {
            Console.WriteLine($"You are playing {Name}");
        }
        public override string ToString()
        {
            return $"The Game is {Name} with {numberOfDice} dies and {numberOfPlayers} players";
        }



    }
}
