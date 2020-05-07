using System;

namespace MyQueue
{
    public class Queue
    {
        public event QueueStateHandler QueueOverflow;
        public event QueueStateHandler QueueAnyElements;

        private double[] _queue;
        private int _index;
        private int _size;
        public Queue(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Size of queue must be more than 0!");
            }
            _size = size;
            _index = -1;
            _queue = new double[size];
        }

        private void CallEvent(QueueEvent e, QueueStateHandler handler)
        {
            if (e != null)
            {
                handler?.Invoke(this,e);
            }
        }

        protected virtual void OnOverflow(QueueEvent e) => CallEvent(e,QueueOverflow);
        protected virtual void OnAnyElements(QueueEvent e) => CallEvent(e,QueueAnyElements);

        public void Push(double elem)
        {
            if (_index+1 >= _size)
            {
                OnOverflow(new QueueEvent("Overflow queue!"));
                return;
            }
            _queue[++_index] = elem;
        }

        public double? Peek()
        {
            if (_index < 0)
            {
                OnAnyElements(new QueueEvent("Queue haven't any elements!"));
                return null;
            }
            return _queue[_index];  
        }

        public void Delete()
        {
            if (_index < 0)
            {
                OnAnyElements(new QueueEvent("Queue haven't any elements!"));
                return;
            }
            _index--;
        }
    }
}