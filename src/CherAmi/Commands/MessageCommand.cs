class MsgCommand : ICommand
{
    public void Execute(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("USAGE: msg <USER> <MESSAGE>");
            return;
        }

        string user = args[0];
        string text = string.Join(" ", args[1..]);
        Console.WriteLine($"MSG->{user}: {text}");
    }
}