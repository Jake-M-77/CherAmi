using System.Text.Json;

public static class Serialiser
{

    public static byte[] Serialise(Message message)
    {
        return JsonSerializer.SerializeToUtf8Bytes(message);
    }


}