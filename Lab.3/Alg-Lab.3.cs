using System;
using System.Collections.Generic;

class Node
{
    public int Value;
    public List<Node> Neighbors;

    public Node(int value)
    {
        Value = value;
        Neighbors = new List<Node>();
    }
}


class GraphLab
{
    static void Main()
    {
        Node root = BuildGraph();

        Console.WriteLine("Sum of neighbors of Node 2: " + SumOfNeighbors(root.Neighbors[0]));
        Console.WriteLine();

        Console.WriteLine("DFS traversal:");
        DFS(root, new HashSet<Node>());
        Console.WriteLine();

        Console.WriteLine("\nBFS traversal:");
        BFS(root);
        Console.WriteLine("\n");
    }


    // building grafss
    public static Node BuildGraph()
    {
        Node n1 = new Node(1);
        Node n2 = new Node(2);
        Node n3 = new Node(3);
        Node n4 = new Node(4);

        n1.Neighbors.Add(n2);
        n1.Neighbors.Add(n4);
        n2.Neighbors.Add(n3);
        n2.Neighbors.Add(n4);
        n3.Neighbors.Add(n4);

        return n1; // return of the root node (кореневойй узел)
    }


    // Sum of neighbor values
    public static int SumOfNeighbors(Node node)
    {
        int sum = 0;
        foreach (var neighbor in node.Neighbors)
        {
            sum += neighbor.Value;
        }
        return sum;
    }


    // DFS recursive (рекурсивный)
    public static void DFS(Node node, HashSet<Node> visited)
    {
        if (node == null || visited.Contains(node)) return;

        Console.Write(node.Value + " ");
        visited.Add(node);

        foreach (var neighbor in node.Neighbors)
        {
            DFS(neighbor, visited);
        }
    }


    // BFS - using queue (с использованием очереди)
    public static void BFS(Node start)
    {
        Queue<Node> queue = new Queue<Node>();
        HashSet<Node> visited = new HashSet<Node>();

        queue.Enqueue(start);
        visited.Add(start);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Value + " ");

            foreach (var neighbor in current.Neighbors)
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }
    }
}