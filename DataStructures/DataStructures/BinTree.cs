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

        public void AddOnFree(int val) { 
        
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
                Node left = Head.Left;
                Node right = Head.Right;
                _addOnFree(left, right, val);
            }

        }

        private void _addOnFree(Node left, Node right, int val) {
            if(left.Left == null)
            {
                left.Left = new Node(val);
                return;
            }
            else if (left.Right == null)
            {
                left.Right = new Node(val);
                return;
            }
            else if(right.Left == null)
            {
                right.Left = new Node(val);
                return;
            }
            else if (right.Right == null)
            {
                right.Right = new Node(val);
                return;
            }
            else
            {
                _addOnFree(left.Left, left.Right, val);
                _addOnFree(right.Left, right.Right, val);
            }
        }

        public void PreFixLeft(Node n)
        {
            if (n == null) return;

            Console.Write(n.Value + " - ");

            PreFixLeft(n.Left);
            PreFixLeft(n.Right);
        }

        public void PreFixRight(Node n)
        {
            if (n == null) return;

            Console.Write(n.Value + " - ");

            PreFixRight(n.Right);
            PreFixRight(n.Left); 
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
