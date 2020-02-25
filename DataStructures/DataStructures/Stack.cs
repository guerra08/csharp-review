using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Stack:LinkedList
    {
        public Stack():base()
        {

        }

        public Stack(int val) : base(val)
        {

        }

        public void Push(int val)
        {
            Add(val);
        }

        public void Pop()
        {
            RemoveTail();
        }

        public void PrintStack()
        {
            PrintList();
        }
    }

}
