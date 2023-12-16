namespace DefaultNamespace;

using System.Collections.Generic;

public class MaxHeap<T>
{
    public PriorityQueue<T, int> Queue { get; set; }
    
    public MaxHeap()
    {
        Queue = new PriorityQueue<T, int>(new MaxHeapComparer());
    }

    public void Add(T node, int val)
    {
        Queue.Enqueue(node, val);
    }
    
    public T Peek()
    {
        return Queue.Peek();
    }

    public T GetMax()
    {
        return Queue.Dequeue();
    }
}