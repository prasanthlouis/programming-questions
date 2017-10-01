using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class FindLCAOfBinaryTree
    {
        internal void FindLowestCA()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 4: LCA of binary tree");
            var tree = ConstructTree();
            FindLCA(tree, 4, 5);
        }

        private void FindLCA(BinaryTree tree, int first, int second)
        {
        List<BinaryTree> path1 = new List<BinaryTree>();
        List<BinaryTree> path2 = new List<BinaryTree>();
        var doesNode1Exist = FindPaths(tree, path1, first);
        var doesNode2Exist = FindPaths(tree, path2, second);
            if (!doesNode1Exist || !doesNode2Exist)
            {
                Console.WriteLine("Node doesn't exist!");
                return;
            }
            for(int i = 0; i < path1.Count && i < path2.Count; i++)
            {
                if(path1[i]!= path2[i])
                {
                    Console.WriteLine(path1[i - 1]._data);
                    break;
                }
            }


        }

        private bool FindPaths(BinaryTree tree, List<BinaryTree> path, int first)
        {
            if (path == null)
                return false;

            path.Add(tree);
            if (tree._data == first)
                return true;

            if (tree.left != null && FindPaths(tree.left, path, first))
              return true;

            if (tree.right != null && FindPaths(tree.right, path, first))
                return true;

            path.RemoveAt(path.Count - 1);
            return false;

        }

        private BinaryTree ConstructTree()
        {
            var tree = new BinaryTree(1);
            tree.left = new BinaryTree(2);
            tree.left.left = new BinaryTree(4);
            tree.left.right = new BinaryTree(5);
            tree.right = new BinaryTree(3);
            tree.right.left = new BinaryTree(6);
            tree.right.right = new BinaryTree(7);
            return tree;
        }
    }

    public class BinaryTree
    {
        public BinaryTree left;
        public BinaryTree right;
        public int _data;
        public BinaryTree(int data)
        {
            _data = data;
            left = null;
            right = null;
        }
    }
}
