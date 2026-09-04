public class Message
{

    public Guid MessageId { set { _MessageId = value;  } get { return _MessageId; } }

    public string SenderId { set { _SenderId = value; } get { return _SenderId; } }

    public string Content { set { _Content = value; } get { return _Content; } }


    Guid _MessageId;
    string _SenderId;
    string _Content;

    public DateTime Timestamp = DateTime.Now;

}