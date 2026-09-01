

using System.Net;
using System.Net.Sockets;

namespace CherAmi.Networking;

public class TcpClientConnection
{

    private readonly TcpClient _client;
    private readonly string _ipAddress;
    private readonly int _port;

    private NetworkStream _networkStream;

    private Stream.StreamWrite _streamWrite;

    private Stream.StreamRead _streamRead;


    public TcpClientConnection(string ipAddress, int port)
    {
        _ipAddress = ipAddress;
        _port = port;
        _client = new TcpClient();

    }

    public async Task ConnectAsync()
    {
        IPAddress address = IPAddress.Parse(_ipAddress);
        await _client.ConnectAsync(address, _port);

        Console.WriteLine("--=Connected=--");

        _networkStream = _client.GetStream();

        _streamWrite = new Stream.StreamWrite(_networkStream);
        _streamRead = new Stream.StreamRead(_networkStream);
    }

    public void Disconnect()
    {
        _client.Close();
        Console.WriteLine("--=DISCONNECTED=--");
    }
}