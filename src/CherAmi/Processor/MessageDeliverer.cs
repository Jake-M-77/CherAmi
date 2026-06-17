using CherAmi;

class MessageDeliverer
{
    public void Display(string recipient, Message msg)
    {
        Console.WriteLine($"{msg.SenderId}->{recipient} @ {msg.Timestamp}: {msg.Content}");
    }
}