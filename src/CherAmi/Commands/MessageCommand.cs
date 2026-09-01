using System.Threading.Tasks;
using CherAmi;
using CherAmi.Networking;

class MsgCommand : ICommand
{
    public async Task Execute(string[] args, ShellContext context)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("USAGE: msg <USER> <MESSAGE>");
            return;
        }

        MessageProcessor messageProcess = new MessageProcessor();

        Message msg = messageProcess.ProcessMessage(string.Join(" ", args[1..]));

        await context.tcpClientConnection.SendMessage(msg);

    }
}