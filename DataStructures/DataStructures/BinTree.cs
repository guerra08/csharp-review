using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BinTree
    {
        public Node Head { get; set; }

        public BinTree(int value)
        {
            Head = new Node(value);
        }

        public BinTree()
        {
            Head = null;
        }

        public void addOnFree(int val) { 
        
            if(Head == null)
            {
                Head = new Node(val);
            }
            else if(Head.Left == null)
            {
                Head.Left = new Node(val);
            }
            else if(Head.Right == null)
            {
                Head.Right = new Node(val);
            }
            else
            {
                _addOnFree(Head.Left, val);
                _addOnFree(Head.Right, val);
            }

        }

        private void _addOnFree(Node n, int val) {
            if (n.Left == null)
            {
                n.Left = new Node(val);
            }
            else if (n.Right == null)
            {
                n.Right = new Node(val);
            }
            else
            {
                _addOnFree(n.Left, val);
                _addOnFree(n.Right, val);
            }
        }

        public void preFixLeft(Node n)
        {
            if(n != null)
            {
                Console.Write(n.Value + " - ");
            }
            if (n.Left != null) { preFixLeft(n.Left); }
            if(n.Right != null) { preFixLeft(n.Right); }
        }

        public void preFixRight(Node n)
        {
            if (n != null)
            {
                Console.Write(n.Value + " - ");
            }
            if (n.Left != null) { preFixRight(n.Right); }
            if (n.Right != null) { preFixRight(n.Left); }
        }

        public class Node
        {
            public int Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(int value, Node left, Node right)
            {
                Value = value;
                Left = left;
                Right = right;
            }

            public Node(int value) 
            {
                Value = value;
                Left = null;
                Right = null;
            }

        }

    }

}
