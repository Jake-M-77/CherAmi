

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
                        if (parsed.Args.Length < 2)
                        {
                            Console.WriteLine("USAGE: msg <USER> <MESSAGE>");
                            return true;
                        }

                        string user = parsed.Args[0];
                        string text = string.Join(" ", parsed.Args[1..]);
                        Console.WriteLine($"{parsed.Command}->{user}: {text}");
                        return true;
                        break;

                    case "exit":
                        Console.WriteLine("Shutting down CherAmi...");
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