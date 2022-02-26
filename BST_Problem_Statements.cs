using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Trees
{
    internal class BST_Problem_Statements<T>
    {
        public BST<T> rootNode;
        int leftTreeCounter = 0;
        int rightTreeCounter = 0;

        // For searching a Node in Binary Tree.
        public void Search(T data)
        {
            if (rootNode == null)
            {
                Console.WriteLine("Binary Tree is not available");
            }
            else
            {
                BST<T> temp = rootNode;
                bool ifFound = false;
                while(temp.left != null || temp.right != null)
                {
                    if (Comparer<T>.Default.Compare(temp.data, data) < 1)
                    {
                        if (temp.right.data.Equals(data))
                        {
                            Console.WriteLine($"{data} is found at below right of {temp.data} in the Binary Tree");
                            ifFound = true;
                            break;
                        }
                        temp = temp.right;
                    }
                    else
                    {
                        if (temp.left.data.Equals(data))
                        {
                            Console.WriteLine($"{data} is found at below left of {temp.data} in the Binary Tree");
                            ifFound =true;
                            break;
                        }
                        temp = temp.left;
                    }
                }
                if (ifFound == false)
                {
                    Console.WriteLine($"{data} is not available in this binary tree");
                }
            }
        }
        //For inserting the node in Binary Tree.
        public void Insert(T data)
        {
            BST<T> node = new BST<T>(data);
            if (rootNode == null)
            {
                rootNode = node;
                Console.WriteLine($"{node.data} root node is added");
            }
            else
            {
                BST<T> temp = rootNode;

                while (temp != null)
                {
                    if (Comparer<T>.Default.Compare(temp.data, node.data) < 1)
                    {
                        if (temp.right == null)
                        {
                            temp.right = node;
                            rightTreeCounter++;
                            Console.WriteLine($"{node.data} is added to right side of {temp.data}");
                            break;
                        }
                        temp = temp.right;
                    }
                    else
                    {
                        if (temp.left == null)
                        {
                            temp.left = node;
                            leftTreeCounter++;
                            Console.WriteLine($"{node.data} is added to left side of {temp.data}");
                            break;
                        }
                        temp = temp.left;
                    }
                }
            }
        }
        //For calculating the size of Binary Tree.
        public void size()
        {
            Console.WriteLine($"The size of Binary tree is {leftTreeCounter + rightTreeCounter + 1}");
        }
    }
}
