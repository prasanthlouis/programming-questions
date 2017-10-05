using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Questions.Amazon
{
    public class PointerLinkListDelete
    {
        internal void DeleteNode()
        {
            var linkList = new LinkList(3);
            linkList.next = new LinkList(4);
            linkList.next.next = new LinkList(5);
            linkList.next.next.next = new LinkList(6);
            var copy = linkList;
            Console.WriteLine("\nSolution 15: Given only a pointer/reference to a node to be deleted in a singly linked list, how do you delete it?");

            while (copy.next != null)
            {
                Console.Write($"{copy._data}->");
                copy = copy.next;
            }
            Console.Write(copy._data);
            //Passing head in just to print
            DeleteNode(linkList.next, linkList);
        }

        private void DeleteNode(LinkList next, LinkList linklist)
        {
            var nextNode = next.next;
            next._data = nextNode._data;
            next.next = nextNode.next;
            var copy = linklist;
            Console.WriteLine();
            while (copy.next != null)
            {
                Console.Write($"{copy._data}->");
                copy = copy.next;
            }
            Console.Write(copy._data);
            Console.WriteLine();
        }

        public class LinkList
        {
            public LinkList next;
            public int _data;
            public LinkList(int data)
            {
                _data = data;
                next = null;
            }
        }
    }
}
