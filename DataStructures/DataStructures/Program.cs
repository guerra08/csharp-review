using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinTree t = new BinTree(15);
            t.AddOnFree(20);
            t.AddOnFree(25);
            t.AddOnFree(35);
            t.AddOnFree(256);
            t.PreFixLeft(t.Head);
            Console.WriteLine("\n------");
            t.PreFixRight(t.Head);

        }
    }
}
