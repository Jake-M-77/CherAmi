
using System.Net;
using System.Net.Sockets;

namespace CherAmi.Networking;

public class TcpServer
{

    private readonly TcpListener _listener;
    private TcpClient? _client;

    public TcpServer(string ipAddress, int port)
    {
        IPAddress address = IPAddress.Parse(ipAddress);
        _listener = new TcpListener(address, port);
    }

    public async Task StartAsync()
    {
        _listener.Start();

        _client = await _listener.AcceptTcpClientAsync();

        await HandleClientAsync(_client);

    }

    private async Task HandleClientAsync(TcpClient client)
    {
        Console.WriteLine("--=CLIENT CONNECTED=--");

    }

    public void Stop()
    {

    }

}




