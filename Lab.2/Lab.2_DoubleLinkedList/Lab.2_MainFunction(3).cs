using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alg_Lab._2_DLL
{
    class MainFunction
    {
        public static void Main()
        {
            DoubleLinkedList list = new DoubleLinkedList();

            Node first = list.InsertAfter(null, 10);
            Node second = list.InsertAfter(first, 20);
            Node third = list.InsertAfter(second, 30);

            Console.WriteLine("Before adding elements :");
            list.PrintList();
            Console.WriteLine();

            Node found = list.Find(20);
            if (found != null)
            {
                Console.WriteLine($"Found node with the value: {found.value}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Node isn't found!");
                Console.WriteLine();
            }

            list.Remove(second);
            Console.WriteLine("After deleting the nodee with value 20:");
            list.PrintList();
        }
    }
}
