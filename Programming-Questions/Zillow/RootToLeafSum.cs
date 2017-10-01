using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Zillow
{
    public class RootToLeafSum
    {
        internal void SeeIfTheresAPath()
        {
            Console.WriteLine();
            Console.WriteLine($"Problem 2: See if a sum is present from root to leaf.");
            var tree = ConstructATree();
            int sum = 23;
            Console.WriteLine(SeeIfTheresAPath(tree, sum));
        }

        private bool SeeIfTheresAPath(Trees tree, int sum)
        {
            if (tree == null)
                return (sum == 0);
            var answer = false;
            sum = sum - tree.data;
            if (sum == 0 && tree.left == null && tree.right == null)
                return true;
            if (tree.left != null)
                answer = answer || SeeIfTheresAPath(tree.left, sum);
            if (tree.right != null)
                answer = answer || SeeIfTheresAPath(tree.right, sum);
            return answer;

        }

        private Trees ConstructATree()
        {
            var tree = new Trees(10)
            {
                left = new Trees(8)
                {
                    left = new Trees(3),
                    right = new Trees(5)
                },
                right = new Trees(2)
                {
                    left = new Trees(2)
                }
            };
            return tree;
        }
    }

    public class Trees
    {
        public Trees left;
        public Trees right;
        public int data;
        public Trees(int _data)
        {
            data = _data;
            left = null;
            right = null;
        }
    }
}
