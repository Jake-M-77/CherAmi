
using CherAmi;

class ExitCommand : ICommand
{
    public async Task Execute(string[] args, ShellContext context)
    {
        Console.WriteLine("Shutting down CherAmi...");
        context.IsRunning = false;
    }
}