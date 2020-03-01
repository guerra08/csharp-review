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
            else
            {
                if(val > Head.Value)
                {
                    if(Head.Right == null)
                    {
                        Head.Right = new Node(val);
                    }
                    else
                    {
                        _addOnFree(Head.Right, val);
                    }
                }
                else
                {
                    if(Head.Left == null)
                    {
                        Head.Left = new Node(val);
                    }
                    else
                    {
                        _addOnFree(Head.Left, val);
                    }
                }
            }
        }

        private void _addOnFree(Node n, int val)
        {
            if(val > n.Value)
            {
                if(n.Right == null)
                {
                    n.Right = new Node(val);
                }
                else
                {
                    _addOnFree(n.Right, val);
                }
            }
            else
            {
                if(n.Left == null)
                {
                    n.Left = new Node(val);
                }
                else
                {
                    _addOnFree(n.Left, val);
                }
            }
        }
    }
}
