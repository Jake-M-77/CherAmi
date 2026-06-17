using CherAmi;

class MessageProcessor
{
    public Message ProcessMessage(string message)
    {
        Message msg = new Message()
        {
            MessageId = "12345",
            SenderId = "01",
            Content = message,
            Timestamp = DateTime.UtcNow
        };





        return msg;
       
    }
}