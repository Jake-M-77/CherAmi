using System.Text.Json;

public static class Deserialiser
{

    public static Message Deserialise(byte[] message)
    {
        Message receievedMessage = JsonSerializer.Deserialize<Message>(message);
        return receievedMessage;
    }


}