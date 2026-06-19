public class Message
{

    public string MessageId { set { _MessageId = value;  } get { return _MessageId; } }

    public string SenderId { set { _SenderId = value; } get { return _SenderId; } }

    public string Content { set { _Content = value; } get { return _Content; } }

    public int  TicksRemaining { set { _TicksRemaining = value; } get { return _TicksRemaining; } } 


    string _MessageId;
    string _SenderId;
    string _Content;

    int _TicksRemaining;
    public DateTime Timestamp;

}