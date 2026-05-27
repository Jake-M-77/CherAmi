using CherAmi;

interface ICommand
{
    void Execute(string[] args, ShellContext context);
}