using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class BST:BinTree
    {

        public BST() : base()
        {

        }

        public BST(int val) : base(val)
        {

        }

        override public void Add(int val)
        {
            if (Head == null)
            {
                Head = new Node(val);
            }
            else if (Head.Left == null && Head.Value > val)
            {
                Head.Left = new Node(val);
            }
            else if (Head.Right == null && Head.Value <= val)
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

        private void _addOnFree(Node left, Node right, int val)
        {
            //Rewrite logic here   
        }
    }
}
