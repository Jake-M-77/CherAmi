

using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

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

    public TcpClientConnection(TcpClient client)
    {
        _client = client;
        _networkStream = _client.GetStream();

        _streamWrite = new Stream.StreamWrite(_networkStream);
        _streamRead = new Stream.StreamRead(_networkStream);
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

    public async Task SendMessage(Message message)
    {

        byte[] serialisedMessage = Serialiser.Serialise(message);

        byte[] framedData = FrameOutgoingData.FrameData(serialisedMessage);

        await _streamWrite.WriteOutgoingData(framedData);

    }

    public async Task<Message> ReceiveMessage()
    {

        byte[] receivedHeader = await _streamRead.ReadIncomingData(4);

        int messageLength = BitConverter.ToInt32(BitConverter.IsLittleEndian ? receivedHeader.Reverse().ToArray() : receivedHeader);

        byte[] receivedMessage = await _streamRead.ReadIncomingData(messageLength);

        byte[] recievedData = new byte[4 + messageLength];

        Buffer.BlockCopy(receivedHeader, 0, recievedData, 0, 4);
        Buffer.BlockCopy(receivedMessage, 0, recievedData, 4, messageLength);

        byte[] unFramedMessage = InterpretIncomingFraming.InterpretFraming(recievedData);

        Message message = Deserialiser.Deserialise(unFramedMessage);

        return message;

        //Dont, just dont IYKYK

    }

}