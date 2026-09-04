using CherAmi;

interface ICommand
{
    Task Execute(string[] args, ShellContext context);
}