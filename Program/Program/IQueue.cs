namespace Program
{
    public interface IQueue<T>
    {
        T Dequeue();
        void Enqueue(T NewElement);
        int Count { get; }
        T First { get; }
        T Last { get; }
        bool IsEmpty { get; }
    }
}
