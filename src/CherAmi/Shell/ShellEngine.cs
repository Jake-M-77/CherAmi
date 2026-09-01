using System.Threading.Tasks;
using CherAmi.Networking;

namespace CherAmi
{
    public class ShellEngine
    {
        private bool _isRunning = true;

        private readonly CommandParser _parser = new CommandParser();

        private readonly CommandRouter _Router = new CommandRouter();

        private TcpClientConnection _tcpClient;
        private TcpServer _tcpServer;

        public ShellEngine(TcpClientConnection tcpClient)
        {
            _tcpClient = tcpClient;
        }

        public ShellEngine(TcpServer tcpServer)
        {
            _tcpServer = tcpServer;
        }

        public async Task Run()
        {
            Console.WriteLine("CherAmi Shell started, type 'exit' to quit");

            var context = new ShellContext();
            context.IsRunning = true;

            context.tcpClientConnection = _tcpClient;

            while (context.IsRunning)
            {
                Console.Write("CherAmi@shell> ");
                string input = Console.ReadLine();

                await HandleInput(input, context);
            }



        }

        private async Task HandleInput(string input, ShellContext context)
        {

            

            ParsedCommand parsed = _parser.Parse(input);
            await _Router.Route(parsed, context);
        }


    }

    public class ShellContext
    {
        public bool IsRunning { get; set; }

        public TcpClientConnection tcpClientConnection { get; set; }

        // public MessageQueue _messageQueue = new MessageQueue();
    }
}