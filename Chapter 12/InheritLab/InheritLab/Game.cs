using System;

namespace InheritLab
{
    public abstract class Game
    {
        public string Name { get; set; }

        public Game() { }

        public Game(string name)
        {
            Name = name;
        }

        public virtual void StartGame()
        {
            Console.WriteLine("The game has begun!");
        }

        public virtual void EndGame() { }

        public override string ToString()
        {
            return "The game is " + Name;
        }
    }
}
