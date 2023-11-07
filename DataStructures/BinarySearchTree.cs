using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructures
{
       // Binary Search Tree is a node-based binary tree data structure which has the following properties:
      // 1- The left subtree of a node contains only nodes with keys lesser than the node’s key.
     // 2- The right subtree of a node contains only nodes with keys greater than the node’s key.
    // 3- The left and right subtree each must also be a binary search tree.

    internal class TreeNode:Node
    {
        internal TreeNode rightNode;
        internal TreeNode leftNode;

        public TreeNode(int newData)
        {
            this.data = newData;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
    internal class BinarySearchTree
    {
        TreeNode root;

        internal void insert(int newData)
        {
            TreeNode newNode = new TreeNode(newData);
            if (root == null)
            {
                root = newNode;
                return;
            }

            TreeNode traversalNode = root;
            while(true)
            {
                if (newData < traversalNode.data)
                {
                    if (traversalNode.leftNode == null)
                    {
                        traversalNode.leftNode = newNode;
                        return;
                    }
                    traversalNode = traversalNode.leftNode;
                }

                else if (newData > traversalNode.data)
                {
                    if (traversalNode.rightNode == null)
                    {
                        traversalNode.rightNode = newNode;
                        return;
                    }
                    traversalNode = traversalNode.rightNode;
                }

                else
                {
                    Console.WriteLine("Duplicate values are not allowed in binary search tress");
                    return;
                }
            }
        }

        internal bool Search(int value) // checks if a value exists in the tree or not 
        {                              // O(log n) if balanced, O(n) otherwise 
            if (root == null)
                return false;

            TreeNode traversalNode = root;
            while (traversalNode != null)
            {
                if (value == traversalNode.data)
                {
                    return true;
                }
                else if (value <  traversalNode.data)
                {
                    traversalNode = traversalNode.leftNode;
                }
                else
                {
                    traversalNode = traversalNode.rightNode;
                }
            }
            return false;
        }
    }
}
