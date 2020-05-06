namespace MyQueue
{
    public class QueueEvent
    {
        public string Message { get; }

        public QueueEvent(string mes)
        {
            Message = mes;
        }
    }
}