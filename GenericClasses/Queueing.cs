﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Queueing<T>
{
    private LinkedList<T> list;

    public Queueing()
    {
        list = new LinkedList<T>();
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public void Enqueue(T item)
    {
        list.AddLast(item);
    }

    public T Dequeue()
    {
        if (IsEmpty())
        { 
            throw new InvalidOperationException("Queue is empty");
        }

        T item = list.First.Value;
        list.RemoveFirst();
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return list.First.Value;
    }

    public int Size()
    {
        return list.Count;
    }
}

