

using System.Net;
using System.Net.Sockets;

namespace CherAmi.Networking;

public class TcpClientConnection
{

    private readonly TcpClient _client;
    private readonly string _ipAddress;
    private readonly int _port;


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
    }

    public void Disconnect()
    {
        _client.Close();
    }
}