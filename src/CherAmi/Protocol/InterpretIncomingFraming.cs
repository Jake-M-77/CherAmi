

public static class InterpretIncomingFraming
{

    public static byte[] InterpretFraming(byte[] message)
    {
        byte[] lengthHeader = new byte[4];

        Array.Copy(message, 0, lengthHeader, 0, lengthHeader.Length);

        if (BitConverter.IsLittleEndian)
        {
            Array.Reverse(lengthHeader);
        }


        int payloadLength = BitConverter.ToInt32(lengthHeader, 0);

        byte[] payload = new byte[payloadLength];

        Buffer.BlockCopy(message, lengthHeader.Length, payload, 0, payloadLength);

        return payload;

    }


}