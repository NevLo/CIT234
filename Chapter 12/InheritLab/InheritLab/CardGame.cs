using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritLab
{
    class CardGame : Game, IShuffle
    {
        private int numberOfCards;
        public int NumberOfCards {
            get
            {
                return numberOfCards;
            }
            set
            {
                if (value < 1000 && value > 0)
                {
                    numberOfCards = value;
                }
            }
        }

        public CardGame(int numCards,string name)
        {
            NumberOfCards = numCards;
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
           return $"The Game is {Name} with {numberOfCards} cards...";
        }

        public void ShuffleCards(int times)
        {
            for(int i = 0; i < times; i++)
            {
                Console.WriteLine("Shuffle...");
            }
        }
    }
}
