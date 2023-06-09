﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Stacking<T>
{
    private LinkedList<T> list;

    public Stacking()
    {
        list = new LinkedList<T>();
    }

    public bool IsEmpty()
    {
        return list.Count == 0;
    }

    public void Push(T item)
    {
        list.AddLast(item);
    }

    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = list.Last.Value;
        list.RemoveLast();
        return item;
    }

    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return list.Last.Value;
    }

    public int Size()
    {
        return list.Count;
    }
}


