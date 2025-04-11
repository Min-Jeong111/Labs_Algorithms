using System;

namespace Alg_Lab._2
{
    class SingleLinkedList
    {
        public Node head;
        public Node tail;

        public SingleLinkedList()
        {
            head = null;
            tail = null;
        }

        public Node InsertAfter(Node node, int value)
        {
            Node newNode = new (value);

            if (node == null)
            {
                newNode.next = head;
                head = newNode;

                if (tail == null)
                {
                    tail = newNode;
                }
            }
            else
            {
                newNode.next = node.next;
                node.next = newNode;

                if (node == tail)
                {
                    tail = newNode;
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

        public void RemoveAfter(Node node)
        {
            if (node == null)
            {
                if (head != null)
                {
                    head = head.next;

                    if (head == null)
                    {
                        tail = null;
                    }
                }
            }
            else if (node.next != null)
            {
                if (node.next == tail)
                {
                    tail = node;
                }

                node.next = node.next.next;
            }
        }

        public void PrintList()
        {
            Node current = head;

            while (current != null)
            {
                Console.WriteLine(current.value + " > ");
                current = current.next;
            }

            Console.WriteLine("Null!");
        }



        // Adding AssertNoCyclees
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
                    throw new InvalidOperationException("There's a cycle detected in the linked list!");
                }
            }
        }
    }
}
