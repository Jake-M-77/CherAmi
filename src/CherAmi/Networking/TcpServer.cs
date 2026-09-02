
using System.Net;
using System.Net.Sockets;

namespace CherAmi.Networking;

public class TcpServer
{

    private readonly TcpListener _listener;
    private TcpClient? _client;

    private TcpClientConnection? _clientConnection;
    

    public TcpServer(string ipAddress, int port)
    {
        IPAddress address = IPAddress.Parse(ipAddress);
        _listener = new TcpListener(address, port);
    }

    public async Task RunAsync()
    {
        _listener.Start();

        _client = await _listener.AcceptTcpClientAsync();

        _clientConnection = new TcpClientConnection(_client);

        Console.WriteLine("--=CLIENT CONNECTED=--");

        Task receiveTask = ReceiveMessages(_clientConnection);

        var shell = new ShellEngine(_clientConnection);

        await shell.Run();
    }

    private async Task ReceiveMessages(TcpClientConnection client)
    {
        while (true)
        {
            Console.WriteLine("Waiting for message...");

            Message msg = await client.ReceiveMessage();

            Console.WriteLine(
                $"{msg.MessageId}->{msg.SenderId} @ {msg.Timestamp}: {msg.Content}"
            );
        }
    }

    public void Stop()
    {
        if (_client != null)
        {
            _client.Close();
        }

        _listener.Stop();

        Console.WriteLine("--=SERVER STOPPED=--");
    }

}




