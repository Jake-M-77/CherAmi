

namespace CherAmi
{

    public class CommandParser
    {
        public ParsedCommand Parse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }

            string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string command = parts[0].ToLower();

            string[] args = parts.Length > 1
                ? parts[1..]
                : Array.Empty<string>();

            return new ParsedCommand(command, args);
        }
    }

    public record ParsedCommand(string Command, string[] Args);

}