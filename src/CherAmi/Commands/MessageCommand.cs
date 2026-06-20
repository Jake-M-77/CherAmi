using CherAmi;

class MsgCommand : ICommand
{
    public void Execute(string[] args, ShellContext context)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("USAGE: msg <USER> <MESSAGE>");
            return;
        }

        MessageProcessor messageProcess = new MessageProcessor();


        Message msg = messageProcess.ProcessMessage(string.Join(" ", args[1..]));

        context._messageQueue.AddMessage(msg);

        context._messageQueue.ProcessQueue();

    }
}