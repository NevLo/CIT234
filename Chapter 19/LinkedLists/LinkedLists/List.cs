using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class List
    {
        private Node FirstNode;
        private Node LastNode;
        private int Count { get; set; }
        private string name;

        public List(string name)
        {
            this.name = name;
            FirstNode = null;
            LastNode = null;
            Count = 0;
        }

        public List() : this("list") { }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public void InsertAtFront(object data)
        { 
            if (IsEmpty())
            {
                FirstNode = LastNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data, FirstNode, null);
                FirstNode.Previous = temp;
                FirstNode = temp;
            }
            Count++;
        }
        public void Add(object data)
        {
            if (IsEmpty())
            {
                FirstNode = LastNode = new Node(data);
            }
            else
            {
                Node temp = new Node(data, null, LastNode);
                LastNode.Next = temp;
                LastNode = temp;
            }
            Count++;
        }
        public void AddAt(object data, int pos)
        {
            if (IsEmpty())
            {
                FirstNode = LastNode = new Node(data, null, null);
            }
            else if(pos == 0)
            {
                InsertAtFront(data);
            }
            else if(pos >= Count)
            {
                Add(data);
            }
            else
            {
                var current = FirstNode;
                for (int i = 0; i < pos; i++)
                {
                    current = current.Next;
                }

                Node temp = new Node(data, current, current.Previous);
                current.Previous.Next = temp;
                current.Previous = temp;
                Count++;
            }
        }




        public object RemoveFirst()
        {
            if (IsEmpty())
            {
                return null;
            }
            
            else
            {
                var r = FirstNode.Data;
                if(FirstNode == LastNode)
                {
                    FirstNode = LastNode = null;
                }
                else
                {
                    FirstNode = FirstNode.Next;
                    FirstNode.Previous = null;
                }
                Count--;
                return r;
            }
        }
        public object RemoveLast()
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                var r = LastNode.Data;
                if (FirstNode == LastNode)
                {
                    FirstNode = LastNode = null;
                }
                else
                {
                    LastNode = LastNode.Previous;
                    LastNode.Next = null;
                }
                Count--;
                return r;
            }
        }
        

        public object RemoveAt(int pos)
        {
            object r = null;
            if (IsEmpty())
            {
            }
            else if (pos == 0)
            {
                r = RemoveFirst();
            }
            else if(pos == Count - 1)
            {
                r = RemoveLast();
            }
            else
            {
                
                var current = FirstNode;
                for(int i = 0; i < pos; i++)
                {
                    current = current.Next;
                }

                r = current.Data;
                current.Next.Previous = current.Previous;
                current.Previous.Next = current.Next;
                Count--;
                
            }
            return r;
        }


        public void Display()
        {
            Console.Write($"{name}:[");
            if (IsEmpty())
            {
                Console.WriteLine("]");
            }
            else
            {
                Node current = FirstNode;
                for(int i = 0; i < Count; i++)
                {
                    Console.Write($"{current.Data},");
                    current = current.Next;
                }
                Console.WriteLine("]");
            }
        }

    }
}
