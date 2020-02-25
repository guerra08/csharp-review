using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    //Queue, where the first element that enters is the first one to be used ()
    class Queue 
    {

        public Node First { get; set; }
        public Node Last { get; set; }
        public int Count { get; set; }

        public Queue()
        {
            First = null;
            Last = null;
            Count = 0;
        }

        public Queue (int val)
        {
            First = new Node(val);
            Last = First;
            Count = 1;
        }

        public void Enqueue (int val)
        {
            if (Count == 0)
            {
                First = new Node(val);
                Last = First;
                Count++;
            }
            else if (Count == 1)
            {
                First.Next = new Node(val);
                Last = First.Next;
                Last.Next = null;
                Count++;
            }
            else
            {
                Node aux = Last;
                aux.Next = new Node(val);
                Last = aux.Next;
                Last.Next = null;
                Count++;
            }
            
        }

        public void Dequeue()
        {
            if (Count == 0)
            {
                Console.WriteLine("Empty queue");
            }
            if (Count == 1)
            {
                First = null;
                Last = null;
                Count = 0;
            }
            else
            {
                First = First.Next;
                Count--;
            }
        }

        public void PrintQueue()
        {
            int c = 0;
            Node n = First;
            while (c < Count)
            {
                Console.WriteLine(n.Val);
                n = n.Next;
                c++;
            }
            Console.WriteLine("----");
        }

    }
}
