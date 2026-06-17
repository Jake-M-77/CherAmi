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
        MessageDeliverer DeliveryAgent = new MessageDeliverer();


        Message msg = messageProcess.ProcessMessage(string.Join(" ", args[1..]));


        DeliveryAgent.Display(args[0], msg);

    }
}