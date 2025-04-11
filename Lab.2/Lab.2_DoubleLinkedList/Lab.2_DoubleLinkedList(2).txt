using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab._2_DLL
{
    class DoubleLinkedList
    {
        public Node head;
        public Node tail;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
        }

        public Node InsertAfter(Node node, int value)
        {
            Node newNode = new Node(value);

            if (node == null)
            {
                newNode.next = head;
                if (head != null)
                {
                    head.prev = newNode;
                }
                head = newNode;

                if (tail == null)
                {
                    tail = newNode;
                }
            }
            else
            {
                newNode.next = node.next;
                newNode.prev = node;
                node.next = newNode;

                if (newNode.next != null)
                {
                    newNode.next.prev = newNode;
                }
                else
                {
                    tail = newNode;
                }
            }

            return newNode;
        }

        public Node InsertBefore(Node node, int value)
        {
            Node newNode = new Node(value);

            if (node == null)
            {
                newNode.prev = tail;
                if (tail != null)
                {
                    tail.next = newNode;
                }
                tail = newNode;

                if (head == null)
                {
                    head = newNode;
                }
            }
            else
            {
                newNode.prev = node.prev;
                newNode.next = node;
                node.prev = newNode;

                if (newNode.prev != null)
                {
                    newNode.prev.next = newNode;
                }
                else
                {
                    head = newNode;
                }
            }

            return newNode;
        }

        public Node Find(int value)
        {
            Node current = head;

            while (current != null)
            {
                if (current.value == value)
                {
                    return current;
                }
                current = current.next;
            }

            return null;
        }

        public void Remove(Node node)
        {
            if (node == null)
            {
                return;
            }

            if (node.prev != null)
            {
                node.prev.next = node.next;
            }
            else
            {
                head = node.next;
            }

            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
            else
            {
                tail = node.prev;
            }
        }

        public void AssertNoCycles()
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (slow == fast)
                {
                    throw new InvalidOperationException("Found a cycle in the double list!");
                }
            }
        }

        public void PrintList()
        {
            Node current = head;
            Console.Write("List: ");

            while (current != null)
            {
                Console.Write(current.value + " <-> ");
                current = current.next;
            }

            Console.WriteLine("null");
        }
    }
}
