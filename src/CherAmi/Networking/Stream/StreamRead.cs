using System.Net.Sockets;

namespace CherAmi.Networking.Stream;


public class StreamRead
{
    private readonly NetworkStream _networkStream;


    public StreamRead(NetworkStream networkStream)
    {
        _networkStream = networkStream;
    }

    public async Task<byte[]> ReadIncomingData(int cbytes)
    {

        byte[] readbytes = new byte[cbytes];

        int bytesRecieved = 0;

        while (bytesRecieved < cbytes)
        {
            int remaining = cbytes - bytesRecieved;

            int bytesRead = await _networkStream.ReadAsync(readbytes, bytesRecieved, remaining);

            bytesRecieved += bytesRead;

            if (bytesRead == 0)
            {
                throw new Exception("The connection was closed before the expected number of bytes were received.");
            }
        }


        return readbytes;
    }

}