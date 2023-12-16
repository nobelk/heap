namespace DefaultNamespace;

using System.Collections.Generic;

public class MinHeap<T>
{
    public PriorityQueue<T, int> Queue { get; set; }
    
    public MinHeap()
    {
        Queue = new PriorityQueue<T, int>();
    }

    public void Add(T node, int val)
    {
        Queue.Enqueue(node, val);
    }

    public T Peek()
    {
        return Queue.Peek();
    }

    public T GetMin()
    {
        return Queue.Dequeue();
    }
}