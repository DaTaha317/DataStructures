using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // A linked list is a linear data structure, in which the elements are not stored at contiguous memory locations
    // Each location (Node) points to the next one (like a chain)
    internal class SinglyLinkedList
    {
        Node head;
        public int length = 0;

        internal void display() // O(n)
        {
            Node traversalNode = head;
            while(traversalNode != null)
            {
                Console.WriteLine(traversalNode.data);
                traversalNode = traversalNode.nextNode;
            }
        }

        // A traversal method to use in upcoming inserting methods to reduce code redundancy 
        // Indexing starting from 0
        private Node traverse(int index)
        {
            // Avoiding indexing out of bounds
            if (index > length - 1)
                index = length - 1;

            if (index <= 0)
                return head;

            Node traversalNode = head;
            for (int i = 0; i < index ; i++)
            {
                traversalNode = traversalNode.nextNode;
            }
            return traversalNode;
        }
        internal void prepend(int newData) // O(1)
        {
            Node newNode = new Node(newData);

            if (head == null)
                head = newNode;
            else
            {
                // Changing pointers and values
                newNode.nextNode = head;
                head = newNode;
            }
            length++;
        }

        internal void append(int newData) // O(n)
        {
            Node newNode = new Node(newData);

            if (head == null)
                head = newNode;
            else
            {
                // Getting the last node and pointing it to the new one
                Node lastNode = traverse(length);
                lastNode.nextNode = newNode;
            }
            length++;
        }

        internal void insert(int index, int newData) // O(1) into the beginning O(n) otherwise
        {
            Node newNode = new Node(newData);

            switch (index)
            {
                case <= 0:
                    prepend(newData);
                    break;
                case int value when value >= length: // ByPassing switch statement only evaluating constants not variables 
                    append(newData);
                    break;
                default:
                    // Changing pointers and values 
                    Node prevNode = traverse(index - 1);
                    newNode.nextNode = prevNode.nextNode;
                    prevNode.nextNode = newNode;
                    break;
            }
            length++;
        }

        internal void remove(int index) // O(1) from the beginning O(n) otherwise
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty");
                return;
            }

            // Avoiding indexing out of bounds this time by subtracting 2 since we also need the Node before last
            if (index > length - 2)
                index = length - 2;

            if (index <= 0)
            {
                Node tempNode = head;
                head = tempNode.nextNode; 
            }

            else
            {
                Node prevNode = traverse(index - 1);
                Node currentNode = prevNode.nextNode;
                // Changing pointers deletes the node due to C# garbage collection 
                prevNode.nextNode = currentNode.nextNode;
                currentNode.nextNode = null;
            }
            length--;
        }

        internal void reverse() // O(n)
        {
            // We need 3 temp nodes. prev, current and next to reverse a linked list without messing up the links 

            Node prevNode = null;
            Node currentNode = head;
            Node followingNode = null; // so as not to confuse it with Node.nextNode attribute

            while (currentNode != null)
            {
                followingNode = currentNode.nextNode;
                currentNode.nextNode = prevNode;
                prevNode = currentNode;
                currentNode = followingNode;
            }
            // once we reach the end where currentNode is null, the very last node which is the prevNode is the head
            head = prevNode; 
        }
    }
}
