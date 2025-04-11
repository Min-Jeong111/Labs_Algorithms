using Alg_Lab._2;
using System;

class Program
{
    static void Main()
    {
        SingleLinkedList list = new SingleLinkedList();

        Node first = list.InsertAfter(null, 10);
        Node second = list.InsertAfter(first, 20);
        Node third = list.InsertAfter(second, 30);

        Console.WriteLine("Initial list is: ");
        list.PrintList();

        Node found = list.Find(20);
        if (found != null)
        {
            Console.WriteLine($"Found node with value: {found.value}");
        }
        else
        {
            Console.WriteLine("Node not found");
        }

        list.RemoveAfter(first);
        Console.WriteLine("After remooving node after first: ");
        list.PrintList();
    }
}