

using System.Net.Sockets;

namespace CherAmi.Networking.Stream;


public class StreamWrite
{
    private readonly NetworkStream _networkStream;


    public StreamWrite(NetworkStream networkStream)
    {
        _networkStream = networkStream;
    }


    public async Task WriteOutgoingData(byte[] message)
    {
        await _networkStream.WriteAsync(message);
    }
}