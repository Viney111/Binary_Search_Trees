using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Binary_Search_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BST_Problem_Statements<int> bst = new BST_Problem_Statements<int>();
            //Inserting elements in binary tree.
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Insert(3);
            bst.Insert(16);
            bst.Insert(63);
            bst.Insert(67);
            bst.size();
        }
    }
}
