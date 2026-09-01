using System.Threading.Tasks;
using CherAmi.Networking;

namespace CherAmi
{
    public class App
    {

        public async Task Run()
        {
            Console.WriteLine(@"
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣫⢟⣿⣿⣿⢿
        ⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣞
        ⡿⣿⣿⣿⣿⣿⣿⣿⣿⣟⣿⣭⣯⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣼⣿⣿⣿⣿⣿⣿⣿⢷⡿⠋⠉⣛⣻⣿⠿⡚⢻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣻⡟⣄⠀⠤⡜⡻⢇⠿⢇⢸⣠⠘⠛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣟⢊⣤⡤⣄⡀⠑⠠⠈⢜⠆⣁⢸⠢⢎⣷⣿⣷⣶⣶⣿⡿⣿⣟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣽⣷⡀⠀⠀⠀⠈⠐⠒⢂⠤⣸⣿⣿⣿⣿⣿⣿⣿⣿⣟⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠆⢸⣿⣾⣿⣿⣿⣷⣟⣽⣿⣟⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣆⠀⡀⢀⠠⡘⣤⣿⣿⠙⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣷⠠⡻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⡀⢂⠵⣸⢷⡿⣿⣷⣄⠊⣮⠻⠿⣿⣿⣯⢿⣿⠃⢠⣧⢘⡙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡻⣸⠭⡫⡿⡽⣻⣿⣷⣄⠛⠛⠦⡑⠭⣥⣴⣾⠷⠁⣘⡇⢖⣔⢮⢍⡹⣿⢿⣿⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⠗⢈⠳⡙⡖⡫⠞⣹⢓⠤⣀⣤⣤⢀⠀⠀⠀⠘⠑⠒⠒⠒⠉⠠⠼⠈⠙⠹⣿⣿⣿
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣬⠃⠑⠘⢡⠈⠀⠀⠈⠁⠈⠙⠈⠀⠀⠀⢠⣤⡄⠀⠀⠀⣤⣴⡖⣶⢺⣽⣿⣿
        ⢿⡟⢯⡟⣽⣫⢟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣄⡁⠀⠀⠀⡀⢀⠠⢀⣠⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣟⢇⡯⣳⠻⢀
        ⢑⢎⡳⣝⢧⣛⣮⣿⣿⣿⣿⣿⣿⢿⣿⡿⣿⣿⣿⣿⡿⠿⠻⠏⢉⣀⣴⠛⡲⡟⣵⣿⢿⠿⠿⠿⠿⠿⠟⠿⠛⠛⠙⠓⠈⠒⠀⡀⣀⡀
        ⣚⢮⡵⣾⣻⣿⣾⣿⣿⣿⣿⣿⣞⣷⣮⣳⣹⣎⣿⣏⠡⡀⠁⠀⠁⠈⠁⠀⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⠀⠐⠀⠀⠀⠐⠀⠈⠀⠁
        ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣄⠀⠀⠀⠄⠀⠀⠀⠀⠀⠀⠀⠀⠰⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
            ");

            Console.WriteLine("CherAmi starting...");

            //TEMPORARY 

            Console.WriteLine("Select mode:");
            Console.WriteLine("1. Server");
            Console.WriteLine("2. Client (hit enter to continue as client)");

            Console.Write(">>> ");
            string x = Console.ReadLine();

            if (x == "1")
            {
                var server = new TcpServer("127.0.0.1", 5000);

                await server.StartAsync();

                var shell = new ShellEngine(server); //

                await shell.Run();

                server.Stop();
            }
            else
            {
                var client = new TcpClientConnection("127.0.0.1", 5000);

                await client.ConnectAsync();

                var shell = new ShellEngine(client);

                await shell.Run();

                client.Disconnect();
            }

            //TEMPORARY


        }

    }
}