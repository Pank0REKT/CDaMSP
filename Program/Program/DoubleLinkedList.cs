using System;
using System.Collections;
using System.Collections.Generic;

namespace Program
{
    public class DoublyNode<T>
    {
        public DoublyNode(T data)
        {
            Data = data;
        }
        public T Data { get; set; }
        public DoublyNode<T> Previous { get; set; }
        public DoublyNode<T> Next { get; set; }
    }

    public class DoublyLinkedList<T>:IEnumerable<T>, ICloneable
    {
        public DoublyNode<T> head;
        public DoublyNode<T> tail;
        int count;

        public void AddLast(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);

            if (head == null)
                head = node;
            else
            {
                tail.Next = node;
                node.Previous = tail;
            }
            tail = node;
            count++;
        }
        public void AddFirst(T data)
        {
            DoublyNode<T> node = new DoublyNode<T>(data);
            DoublyNode<T> temp = head;
            node.Next = temp;
            head = node;
            if (count == 0)
                tail = head;
            else
                temp.Previous = node;
            count++;
        }

        public void RemoveLast()
        {
            DoublyNode<T> current = head;
            tail = current.Previous;
        }
        public void Remove(T data)
        {
            DoublyNode<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }

            if (NotLastElement(current))
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                tail = current.Previous;
            }

            if (NotFirstElement(current))
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                head = current.Next;
            }
            count--;
        }
        bool NotLastElement(DoublyNode<T> current)
        {
            return current.Next != null;
        }
        bool NotFirstElement(DoublyNode<T> current)
        {
            return current.Previous != null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            DoublyNode<T> current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public object Clone()
        {
            return new DoublyLinkedList<T>();
        }

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
    }
}
