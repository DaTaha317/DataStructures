using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    // Node class serving as the building block of various data structures 
    internal class Node
    {
        internal int data;
        internal Node nextNode;

         public Node(int newData)
        {
            this.data = newData;
            this.nextNode = null;
        }

        public Node()
        {

        }
    }
}
