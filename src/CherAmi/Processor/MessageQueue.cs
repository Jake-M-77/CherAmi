using CherAmi;

public class MessageQueue
{
    Queue<Message> _messages = new Queue<Message>();

    public void AddMessage(Message newMessage)
    {
        _messages.Enqueue(newMessage);
    }

    public void ProcessQueue()
    {

        if (_messages.Count == 0)
        {
            Console.WriteLine("No messages!");
            return;
        }

        Queue<Message> remaining = new Queue<Message>();
        MessageDeliverer DeliveryAgent = new MessageDeliverer();

        int count = _messages.Count();

        for (int i = 0; i < count; i++)
        {
            Message msg = _messages.Dequeue();

            msg.TicksRemaining--;

            if (msg.TicksRemaining <= 0)
            {
                DeliveryAgent.Display("test", msg);
            }
            else
            {
                remaining.Enqueue(msg);
            }
        }

        _messages = remaining;

    }


}