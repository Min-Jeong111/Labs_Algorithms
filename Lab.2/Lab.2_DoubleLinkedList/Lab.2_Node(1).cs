using System;

class Node
{
    public int value;
    public Node next;
    public Node prev;

    public Node(int value)
    {
        this.value = value;
        next = null;
        prev = null;
    }
}