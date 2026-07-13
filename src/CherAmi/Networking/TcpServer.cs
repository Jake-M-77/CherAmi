
using System.Net;
using System.Net.Sockets;

namespace CherAmi.Networking;

public class TcpServer
{

    private readonly TcpListener _listener;

    public TcpServer(string ipAddress, int port)
    {
        IPAddress address = IPAddress.Parse(ipAddress);
        _listener = new TcpListener(address, port);
    }

    public Task StartAsync()
    {
        _listener.Start();

        return Task.CompletedTask;

    }

    public void Stop()
    {
        
    }

}




