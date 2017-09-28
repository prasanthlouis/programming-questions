using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions
{
    public class LinkList
    {
        Node head;
        internal Node ReverseLinkListInGroupsOfK(Node head)
        {
            //Limit is 3
            var current = head;
            Node next = null;
            Node previous = null;
            var count = 0;
            while (count < 3 && current != null)
            {
                next = current.next;
                current.next = previous;
                previous = current;
                current = next;
                count++;
            }
            if (next != null)
                head.next = ReverseLinkListInGroupsOfK(next);

            return previous;

        }

        internal void ReverseLinkListInGroupsOfKS()
        {
            CreateLinkList();
            var heads = ReverseLinkListInGroupsOfK(head);
            Console.WriteLine("\nSolution 7: Reverse a link list in groups of k");
            while (heads.next != null)
            {
                Console.Write($"{heads._data}->");
                heads = heads.next;
            }
            Console.Write($"{heads._data}");
            Console.WriteLine();
        }

        public void push(int v)
        {
            var node = new Node(v);
            node.next = head;
            head = node;
        }

        private void CreateLinkList()
        {
            push(8);
            push(7);
            push(6);
            push(5);
            push(4);
            push(3);
            push(2);
            push(1);
        }
        public class Node {

            public Node next;
            public int _data;
            public Node(int data)
            {
                _data = data;
                next = null;
            }
        }
        
    }
}
