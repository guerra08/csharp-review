using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinTree t = new BinTree(15);
            //t.AddOnFree(20);
            //t.AddOnFree(25);
            //t.AddOnFree(35);
            //t.AddOnFree(256);
            //t.PreFixLeft(t.Head);
            //Console.WriteLine("\n------");
            //t.PreFixRight(t.Head);

            LinkedList l = new LinkedList(10);
            l.Add(25);
            l.Add(50);
            l.Add(15);
            l.PrintList();
            l.RemoveFirstFound(50);
            l.PrintList();
        }
    }
}
