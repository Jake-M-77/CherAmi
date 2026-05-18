namespace CherAmi
{
    public class ShellEngine
    {
        private bool _isRunning = true;

        private readonly CommandParser _parser = new CommandParser();

        public void Run()
        {
            Console.WriteLine("CherAmi Shell started, type 'exit' to quit");

            while (_isRunning)
            {
                Console.Write("CherAmi@shell> ");
                string input = Console.ReadLine();

                HandleInput(input);
            }



        }

        private void HandleInput(string input)
        {
            ParsedCommand parsed = _parser.Parse(input);

            if (parsed == null) 
            {
                return;
            }

            if (parsed.Command == "exit")
            {
                _isRunning = false;
                Console.WriteLine("Shutting down CherAmi...");
                return;
            }
            else if (parsed.Command == "msg")
            {
                if (parsed.Args.Length < 2)
                {
                    Console.WriteLine("USAGE: msg <USER> <MESSAGE>");
                    return;
                }

                string user = parsed.Args[0];
                string text = string.Join(" ", parsed.Args[1..]);
                
                Console.WriteLine($"{parsed.Command}->{user}: {text}");
            }
            else
            {
                Console.WriteLine($"Unknown command: {input}");
            }

        }
    }
}