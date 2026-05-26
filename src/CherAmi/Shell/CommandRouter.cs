

namespace CherAmi
{
    public class CommandRouter
    {

        public bool Route(ParsedCommand parsed)
        {

            if (parsed == null)
            {
                return true;
            }
            else
            {
                switch (parsed.Command)
                {
                    case "msg":
                        MsgCommand MsgCommand = new MsgCommand();
                        MsgCommand.Execute(parsed.Args);
                        return true;
                        break;

                    case "exit":
                        ExitCommand ExitCommand = new ExitCommand();
                        ExitCommand.Execute(parsed.Args);
                        return false;

                    default:
                        Console.WriteLine($"Unknown command: {parsed.Command}");
                        return true;
                        break;
                }
            }

        }
    }
}