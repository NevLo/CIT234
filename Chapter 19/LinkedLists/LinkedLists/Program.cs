using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List list = new List("Things");

            list.Add(true);
            list.Display();
            list.InsertAtFront(false);
            list.Display();
            list.InsertAtFront(true);
            list.Display();
            list.AddAt("hi", 3);
            list.Display();
        }
    }
}
