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
            bst.Insert(56);
            bst.Insert(30);
            bst.Insert(70);
        }
    }
}
