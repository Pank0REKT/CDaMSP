using System;

namespace Program
{
    public class DoublyLinkedListQueue<T> : IQueue<T>
    {
        DoublyLinkedList<T> queue = new DoublyLinkedList<T>();

        public T Dequeue()
        {
            T temp = queue.tail.Data;
            queue.Remove(queue.tail.Data);
            return temp;
        }

        public void Enqueue(T NewElement)
        {
            queue.AddFirst(NewElement);
        }

        public int Count
        {
            get
            {
                return queue.Count;
            }
        }

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return queue.head.Data;
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException();
                return queue.tail.Data;
            }
        }

        public bool IsEmpty { get { return queue.Count == 0; } }
    }
}

