using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            String temp;
            Console con1 = new Console();


            Switch sw1 = new Switch();

            SegaDreamCast sdc1 = new SegaDreamCast();
            System.Console.WriteLine("BASE CONSOLE");
            ////////////////////////////CONSOLE
            System.Console.WriteLine("Please enter a custom username: (if nothing is entered, one will be made for you)");

            temp = System.Console.ReadLine();
            if(temp.Length <- 1)
            {
                con1.UserName = temp;
            }else
            {
                con1.MakeNewUserName();
            }
            
            System.Console.WriteLine("Please enter the maximum number of players in the game.");
            con1.MaxPlayers = int.Parse(System.Console.ReadLine());

            ////////////////////////////SWITCH
            System.Console.WriteLine("\nSWITCH\n");
            System.Console.WriteLine("Please enter a custom username: (if nothing is entered, one will be made for you)");
            temp = System.Console.ReadLine();
            if (temp.Length <= 1)
            {
                sw1.UserName = temp;
            }
            else
            {
                sw1.MakeNewUserName();
            }
            System.Console.WriteLine("Please enter the maximum number of players in the game.");
            sw1.MaxPlayers = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Would you like to connect another pair of joycons? y/n");
            temp = System.Console.ReadLine().ToLower();
            if (temp.Equals("y"))
            {
                sw1.AddJoyCons();
            }



            ////////////////////////////DREAMCAST
            System.Console.WriteLine("\nDREAMCAST\n");
            System.Console.WriteLine("Please enter a custom username: (if nothing is entered, one will be made for you)");
            temp = System.Console.ReadLine();
            if (temp.Length <= 1)
            {
                sdc1.UserName = temp;
            }
            else
            {
                sdc1.MakeNewUserName();
            }
            System.Console.WriteLine("Please enter the maximum number of players in the game.");
            sdc1.MaxPlayers = int.Parse(System.Console.ReadLine());


            //////////////////////////////OUTPUT

            System.Console.WriteLine("\nConsole\n" +
                con1.UserName + "\n" +
                con1.ConsoleID + "\n" +
                con1.MaxPlayers + "\n" +
                con1.GetPrice() + "\n");
            System.Console.WriteLine("\nSwitch\n" +
                sw1.UserName + "\n" +
                sw1.ConsoleID + "\n" +
                sw1.MaxPlayers + "\n" +
                sw1.GetPrice() + "\n");
            System.Console.WriteLine("\nDreamCast\n" +
                sdc1.UserName + "\n" +
                sdc1.ConsoleID + "\n" +
                sdc1.MaxPlayers + "\n" +
                sdc1.GetPrice() + "\n");







        }
    }
}
