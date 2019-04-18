using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
    public class Node
    {
        public object Data { get; private set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }

        public Node(object data, Node next, Node prev)
        {
            Data = data;
            Next = next;
            Previous = prev;
        }

        public Node(object data) : this(data, null,null) { } 



    }
}
