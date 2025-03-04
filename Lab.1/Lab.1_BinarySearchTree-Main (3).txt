using System.Diagnostics;


namespace Alg_Lab._1_BST
{
    class Program
    {
        static void Main()
        {
            BinarySearchTree bst = new BinarySearchTree();
            int[] numbers = { 8, 5, 33, 15, 1, 4, 20, 1, 9, 11 };

            foreach (int num in numbers)
            {
                bst.Insert(num);
            }

            Console.Write("Enter a number: ");
            int target = Convert.ToInt16(Console.ReadLine());
            Stopwatch stopwatch = Stopwatch.StartNew();
            bool found = bst.Search(target);
            stopwatch.Stop();

            Console.WriteLine($"The number {target} is in the BST: {found}");
            Console.WriteLine($"The time taken for the algorithm to be executed is: {stopwatch.ElapsedTicks} ticks!");
        }
    }
}
