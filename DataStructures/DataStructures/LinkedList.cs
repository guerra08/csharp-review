using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class LinkedList
    {

        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public LinkedList(Node first)
        {
            Head = first;
            Tail = first;
            Head.Next = Tail;
            Tail.Prev = Head;
            Count = 1;
        }

        public LinkedList(int val)
        {
            Node n = new Node(val);
            Head = n;
            Tail = n;
            Head.Next = Tail;
            Tail.Prev = Head;
            Count = 1;
        }

        public void Add(int val)

        {
            Node n = new Node(val);

            if(Count == 0)
            {
                Head = n;
                Tail = n;
                Head.Next = Tail;
                Tail.Prev = Head;
                Count++;
            }
            else if(Count == 1)
            {
                Head.Next = n;
                Tail = n;
                Tail.Prev = Head;
                Count++;
            }
            else
            {
                Node aux = Tail;
                Tail = n;
                Tail.Prev = aux;
                aux.Next = Tail;
                Count++;
            }

        }

        public Boolean RemoveFirstFound(int val) 
        {
            if (Count == 0) return false;
            else
            {
                int c = 0;
                Node n = Head;
                while (c < Count)
                {
                    if (c == 0 && n.Val == val)
                    {
                        Head = n.Next;
                        Head.Prev = null;
                        Count--;
                        return true;
                    }
                    else if (c == Count - 1 && n.Val == val)
                    {
                        Tail = n.Prev;
                        Tail.Next = null;
                        Count--;
                        return true;
                    }
                    else if (n.Val == val)
                    {
                        n.Prev.Next = n.Next;
                        n.Next.Prev = n.Prev;
                        Count--;
                        return true;
                    }
                    c++;
                    n = n.Next;
                }
            }
            return false;
        }

        public Boolean Exists(int val)
        {
            Node n = new Node(val);

            if (Count == 0)
            {
                return false;
            }
            else
            {
                int aux = 0;
                Node check = Head;
                while (aux < Count)
                {
                    if (check.Val == n.Val)
                    {
                        return true;
                    }
                    check = check.Next;
                    aux++;
                }
                return false;
            }
        }

        public void PrintList()
        {
            if(Count == 0)
            {
                Console.WriteLine("Empty list");
            }
            else
            {
                int c = 0;
                Node n = Head;
                while(c < Count)
                {
                    if(c == Count - 1)
                    {
                        Console.WriteLine(n.Val);
                    }
                    else
                    {
                        Console.Write(n.Val + " - ");
                    }
                    c++;
                    n = n.Next;
                }
            }
        }

        public class Node
        {
            public int Val { get; set; }
            public Node Prev { get; set; }
            public Node Next { get; set; }

            public Node(int val)
            {
                Val = val;
                Next = null;
                Prev = null;
            }

            public Node(int val, Node prev, Node next)
            {
                Val = val;
                Prev = prev;
                Next = next;
            }

        }

    }
}
