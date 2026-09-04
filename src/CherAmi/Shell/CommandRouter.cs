

namespace CherAmi
{
    public class CommandRouter
    {

        readonly Dictionary<string, ICommand> CommandLookup = new Dictionary<string, ICommand>
            {
                {"msg", new MsgCommand()},
                {"exit", new ExitCommand()},
            };

        public async Task Route(ParsedCommand parsed, ShellContext context)
        {
            if (parsed == null)
            {
                return;
            }

            ICommand cmd = CommandLookup.GetValueOrDefault(parsed.Command);

            if (cmd == null)
            {
                Console.WriteLine("UNKNOWN COMMAND!");
                return;
            }

            await cmd.Execute(parsed.Args, context);
        }
    }
}