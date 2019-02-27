using System;
namespace InheritLab
{
    public class InheritLab
    {
        public static void Main(string[] args)
        {
            CardGame cg = new CardGame(52, "Tip Me Over");
            DiceGame dg = new DiceGame(5, 25, "Ziltch");
            CardGame cg2 = new CardGame(-45, "No Cards Here!");
            DiceGame dg2 = new DiceGame(56789, -123, "No Dice or Players Here!");

            cg.StartGame();
            cg.EndGame();
            Console.WriteLine(cg.ToString() + "\n");

            cg2.StartGame();
            cg2.EndGame();
            Console.WriteLine(cg2.ToString() + "\n");

            dg.StartGame();
            dg.EndGame();
            Console.WriteLine(dg.ToString() + "\n");

            dg2.StartGame();
            dg2.EndGame();
            Console.WriteLine(dg2.ToString() + "\n");

            cg.ShuffleCards(3);
            Console.WriteLine();
            cg2.ShuffleCards(5);
        }
    }
}
