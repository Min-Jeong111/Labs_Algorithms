using System;

class Node
{
    public int value; // Value we need to get to
    public Node Left; // Left part of the tree
    public Node Right; // Right part of the tree
    public Node(int value)
    {
        this.value = value;
        Left = null;
        Right = null;
    }
}