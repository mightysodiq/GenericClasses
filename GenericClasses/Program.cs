using System;
using System.Collections.Generic;

namespace GenericClasses
{
    

    public class SinglyLinkedList<T>
    {
        private Mynode<T> head { set; get; }
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
            Mynode<T> newNode = new Mynode<T>(item);

            if (IsEmpty())
            {
                head = newNode;
            }
            else
            {
                Mynode<T> current = head;
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

            Mynode<T> current = head;
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
            Mynode<T> current = head;
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
            Mynode<T> current = head;
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