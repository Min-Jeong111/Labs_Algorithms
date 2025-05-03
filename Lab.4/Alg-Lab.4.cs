using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Array Stack ===");
        ArrayStack arrayStack = new ArrayStack(5);
        arrayStack.Push(10);
        arrayStack.Push(20);
        arrayStack.Push(30);
        Console.WriteLine("Top: " + arrayStack.GetLastElement());
        arrayStack.PrintStack();
        arrayStack.Pop();
        Console.WriteLine("After pop:");
        arrayStack.PrintStack();

        Console.WriteLine("\n=== Linked Stack ===");
        LinkedStack linkedStack = new LinkedStack();
        linkedStack.Push(100);
        linkedStack.Push(200);
        linkedStack.Push(300);
        Console.WriteLine("Top: " + linkedStack.GetLastElement());
        linkedStack.PrintStack();
        linkedStack.Pop();
        Console.WriteLine("After pop:");
        linkedStack.PrintStack();

        Console.WriteLine("\n=== Linked Queue ===");
        LinkedQueue queue = new LinkedQueue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine("Front: " + queue.Front());
        queue.PrintQueue();
        queue.Dequeue();
        Console.WriteLine("After de-queue:");
        queue.PrintQueue();
    }
}


// Array-Stack
class ArrayStack
{
    private int[] items;
    private int top;

    public ArrayStack(int capacity)
    {
        items = new int[capacity];
        top = -1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public void Push(int value)
    {
        if (top == items.Length - 1)
        {
            Console.WriteLine("Stack overflow");
            return;
        }
        items[++top] = value;
    }

    public int? GetLastElement()
    {
        if (IsEmpty()) return null;
        return items[top];
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow");
            return;
        }
        top--;
    }

    public void PrintStack()
    {
        for (int i = top; i >= 0; i--)
        {
            Console.Write(items[i] + " ");
        }
        Console.WriteLine();
    }
}


// Linked-list-Stack
class StackNode
{
    public int Value;
    public StackNode Next;

    public StackNode(int value)
    {
        Value = value;
        Next = null;
    }
}


class LinkedStack
{
    private StackNode top;

    public bool IsEmpty()
    {
        return top == null;
    }

    public void Push(int value)
    {
        StackNode node = new StackNode(value);
        node.Next = top;
        top = node;
    }

    public int? GetLastElement()
    {
        return top?.Value;
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack underflow");
            return;
        }
        top = top.Next;
    }

    public void PrintStack()
    {
        StackNode current = top;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}



// Linked-list-Queue
class QueueNode
{
    public int Value;
    public QueueNode Next;

    public QueueNode(int value)
    {
        Value = value;
        Next = null;
    }
}


class LinkedQueue
{
    private QueueNode head;
    private QueueNode tail;

    public bool IsEmpty()
    {
        return head == null;
    }

    public void Enqueue(int value)
    {
        QueueNode node = new QueueNode(value);
        if (IsEmpty())
        {
            head = tail = node;
        }
        else
        {
            tail.Next = node;
            tail = node;
        }
    }

    public int? Front()
    {
        return head?.Value;
    }

    public void Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue underflow");
            return;
        }
        head = head.Next;
        if (head == null)
            tail = null;
    }

    public void PrintQueue()
    {
        QueueNode current = head;
        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}