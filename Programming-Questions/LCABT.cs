using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class LCABT
    {
        List<BinaryTree> path1 = new List<BinaryTree>();
        List<BinaryTree> path2 = new List<BinaryTree>();
        internal void FindLCA(BinaryTree lcaBinaryTree, int v1, int v2)
        {
            Console.WriteLine("\nSolution 5: Find the LCA of a BT");
            Console.WriteLine(FindLCAS(lcaBinaryTree, v1, v2)._data);
        }

        private BinaryTree FindLCAS(BinaryTree lcaBinaryTree, int v1, int v2)
        {

            if (!FindPath(lcaBinaryTree, v1, path1))
            {
                Console.WriteLine($"Cant find {v1}");
                return null;
            }

            if (!FindPath(lcaBinaryTree, v2, path2))
            {
                Console.WriteLine($"Cant find {v2}");
                return null;
            }
            int i = 0;
            for(i = 0; i < path1.Count && i < path2.Count; i++)
            {
                if (!path1[i].Equals(path2[i]))
                    break;
            }
            return path1[i-1];
        }

        private bool FindPath(BinaryTree lcaBinaryTree, int v1, List<BinaryTree> path1)
        {
            if (lcaBinaryTree == null)
                return false;

            if (lcaBinaryTree._data == v1)
                return true;

            path1.Add(lcaBinaryTree);

            if (lcaBinaryTree.left != null && FindPath(lcaBinaryTree.left, v1, path1)){
                return true;
            }

            if (lcaBinaryTree.right != null && FindPath(lcaBinaryTree.right, v1, path1)){
                return true;
            }

            path1.Remove(lcaBinaryTree);
            return false;

        }
    }
}
