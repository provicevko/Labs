namespace Lab7
{
    public sealed class MyListNode<T>
    {
        internal T item;
        internal MyListNode<T> next;
        
        public MyListNode(T value)
        {
            item = value;
        }

        public MyListNode<T> Next => next != null ? next : null;

        public T Value => item;
    }
}