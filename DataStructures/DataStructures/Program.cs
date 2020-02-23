using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinTree t = new BinTree(15);
            t.addOnFree(20);
            t.addOnFree(25);
            t.addOnFree(35);
            t.addOnFree(256);
            t.preFixLeft(t.Head);

        }
    }
}
