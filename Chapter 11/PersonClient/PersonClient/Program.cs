using System;

namespace PersonClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            Person b = new Person("Katalina", 28,false);

            Console.WriteLine(b.getNickName());
            Console.WriteLine(b.getBirthYear());
            int[] sc = b.getShirtColor();
            Console.WriteLine($"Shirt color is <{sc[0]},{sc[1]},{sc[2]}>");

        }
    }
}
