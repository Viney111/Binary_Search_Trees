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
                            Console.WriteLine($"{node.data} is added to right side of {temp.data}");
                            break;
                        }
                        temp = temp.right;
                    }
                    else
                    {
                        if(temp.left == null)
                        {
                            temp.left = node;
                            Console.WriteLine($"{node.data} is added to left side of {temp.data}");
                            break;
                        }
                        temp = temp.left;
                    }
                }
            }
        }
    }
}
