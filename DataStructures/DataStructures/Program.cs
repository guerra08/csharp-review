using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinTree t = new BinTree(15);
            //t.Add(20);
            //t.Add(25);
            //t.Add(35);
            //t.Add(256);
            //t.PreFixLeft(t.Head);
            //Console.WriteLine("\n------");
            //t.PreFixRight(t.Head);

            //LinkedList l = new LinkedList(10);
            //l.RemoveTail();
            //l.PrintList();

            //Queue q = new Queue();
            //q.Enqueue(4);
            //q.Enqueue(8);
            //q.Enqueue(16);
            //q.Enqueue(66);
            //q.PrintQueue();
            //q.Dequeue();
            //q.PrintQueue();

            //Stack s = new Stack(10);
            //s.PrintStack();
            //s.Push(20);
            //s.Push(32);
            //s.PrintStack();
            //s.Pop();
            //s.PrintStack();

            BST bt = new BST(10);
            bt.Add(9);
            bt.Add(17);
            bt.Add(20);
            bt.Add(8);

            Console.WriteLine(bt.Head.Left.Right.Value);
        }
    }
}
