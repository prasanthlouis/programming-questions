using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class LCABST
    {
        internal void FindLCA(BinaryTree lcabst, int v1, int v2)
        {
            Console.WriteLine("\n\nSolution 4: Find the LCA of a BST");
            Console.WriteLine(FindLCAs(lcabst, v1, v2)._data);
        }

        private BinaryTree FindLCAs(BinaryTree lcabst, int v1, int v2)
        {
            if (lcabst == null)
                return null;

            if (lcabst._data > v1 && lcabst._data > v2)
                 return FindLCAs(lcabst.left, v1, v2);

            if (lcabst._data < v1 && lcabst._data < v2)
                 return FindLCAs(lcabst.right, v1, v2);

                 return lcabst;
        }
    }
}
