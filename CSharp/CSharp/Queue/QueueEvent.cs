namespace MyQueue
{
    public delegate void QueueStateHandler(object sender, QueueEvent e);
    public class QueueEvent
    {
        public string Message { get; }

        public QueueEvent(string mes)
        {
            Message = mes;
        }
    }
}