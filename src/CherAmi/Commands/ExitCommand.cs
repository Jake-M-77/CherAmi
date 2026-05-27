
using CherAmi;

class ExitCommand : ICommand
{
    public void Execute(string[] args, ShellContext context)
    {
        Console.WriteLine("Shutting down CherAmi...");
        context.IsRunning = false;
    }
}