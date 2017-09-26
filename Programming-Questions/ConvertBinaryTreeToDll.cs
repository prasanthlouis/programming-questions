using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class ConvertBinaryTreeToDll
    {
        private BinaryTree binaryTree;
        private LinkedList<BinaryTree> binaryLinkList = new LinkedList<BinaryTree>();
        internal void MakeADLL(BinaryTree binaryTree)
        {
            Console.WriteLine("Solution 3: Convert a binary tree to a doubly link list");
            MakeADLLAgain(binaryTree);
            foreach(var node in binaryLinkList)
            {
                if(node != binaryLinkList.Last.Value)
                Console.Write($"{node._data}->");
            }
            Console.Write($"{binaryLinkList.Last.Value._data}");
        }

        private void MakeADLLAgain(BinaryTree binaryTree)
        {
            if(binaryTree == null)
                return;

            MakeADLLAgain(binaryTree.left);
            if (binaryLinkList.First == null)
                binaryLinkList.AddFirst(binaryTree);
            else
                binaryLinkList.AddLast(binaryTree);
            MakeADLLAgain(binaryTree.right);
        }
    }
}
