using System;
using System.Collections.Generic;

namespace task_week_2
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        private Node<T> head;
        private int count;

        public int Count
        {
            get { return count; }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void Adding(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public bool Removing(T item)
        {
            if (IsEmpty())
            {
                return false;
            }

            if (head.Data.Equals(item))
            {
                head = head.Next;
                count--;
                return true;
            }

            Node<T> current = head;
            while (current.Next != null)
            {
                if (current.Next.Data.Equals(item))
                {
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }
                current = current.Next;
            }

            return false;
        }

        public bool Check(T item)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Index(T item)
        {
            Node<T> current = head;
            int index = 0;
            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }
            return -1;
        }
    }

}