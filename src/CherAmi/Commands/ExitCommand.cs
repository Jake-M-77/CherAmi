
class ExitCommand : ICommand
{
    public void Execute(string[] args)
    {
        Console.WriteLine("Shutting down CherAmi...");
    }
}