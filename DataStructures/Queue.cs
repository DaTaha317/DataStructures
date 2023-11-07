using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // A Queue is defined as a linear data structure that is open at both ends
    // Operations are performed in First In First Out (FIFO) order.
    // Like a waiting line - first come first serve 
    internal class Queue
    {
        private Node first;
        private Node last;
        public int length = 0;

        internal void enqueue(int newData) // O(1)
        {
            Node newNode = new Node(newData);

            if (first == null)
            {
                first = last = newNode;
                return;
            }

            last.nextNode = newNode;
            last = newNode;
            length++;
        }

        internal int dequeue() // O(1)
        {
            if (length == 0)
            {
                first = null;
                return -1;
            }

            Node theFirstNode = first;
            first = first.nextNode;
            length--;
            return theFirstNode.data;
        }

        internal void peek() // shows the first element in line O(1)
        {
            if (first == null)
                Console.WriteLine("The Queue is empty!!");
            else
                Console.WriteLine(first.data);
        }

        internal void display() // O(n)
        {
            Node traversalNode = first;
            while (traversalNode != null)
            {
                Console.WriteLine(traversalNode.data);
                traversalNode = traversalNode.nextNode;
            }
        }
    }
}
