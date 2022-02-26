using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Trees
{
    internal class BST<T>
    {
        public T data;
        public BST<T> left;
        public BST<T> right;

        public BST(T data)
        {
            this.data = data;
        }
    }
}
