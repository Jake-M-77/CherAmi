

public static class FrameOutgoingData
{

    public static byte[] FrameData(byte[] message)
    {

        int messageLength = Buffer.ByteLength(message);

        byte[] bytelength = BitConverter.GetBytes(messageLength);

        if (BitConverter.IsLittleEndian)
        {
            Array.Reverse(bytelength);
        }

        byte[] framedMessage = new byte[bytelength.Length + message.Length];

        Buffer.BlockCopy(bytelength, 0, framedMessage, 0, bytelength.Length);

        Buffer.BlockCopy(message, 0, framedMessage, bytelength.Length, messageLength);


        return framedMessage;

    }

}