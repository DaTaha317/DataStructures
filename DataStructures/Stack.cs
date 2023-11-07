using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    //Stacks in Data Structures is a linear type of data structure that follows the LIFO (Last-In-First-Out)
    //principle and allows insertion and deletion operations from one end of the stack data structure, that is top
    // Like a dish stack
    internal class Stack 
    {
        private Node top;

        internal void push(int newData)   // O(1)
        {
            Node newNode = new Node(newData);
            newNode.nextNode = top;
            top = newNode;
        }

        internal int pop()   // O(1)
        {
            if (top == null)
                return -1;

            int popValue = top.data;
            top = top.nextNode;
            return popValue;
        }

        internal void peek()  // O(1)
        {
            if (top == null)
                return;

            Console.WriteLine(top.data);
        }

        internal void display()  // O(n)
        {
            Node traversalNode = top;
            while (traversalNode != null)
            {
                Console.WriteLine(traversalNode.data);
                traversalNode = traversalNode.nextNode;
            }
        }
    }
}
