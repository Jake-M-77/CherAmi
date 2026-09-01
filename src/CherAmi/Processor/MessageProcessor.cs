using CherAmi;

class MessageProcessor
{
    public Message ProcessMessage(string message)
    {
        Message msg = new Message()
        {
            MessageId = Guid.NewGuid(),
            SenderId = "01",
            Content = message,
            Timestamp = DateTime.UtcNow,
        };





        return msg;
       
    }
}