using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class BinaryTree
    {
        public int _data;
        public BinaryTree left;
        public BinaryTree right;
        public BinaryTree(int data)
        {
            _data = data;
            left = null;
            right = null;
        }
    }
}
