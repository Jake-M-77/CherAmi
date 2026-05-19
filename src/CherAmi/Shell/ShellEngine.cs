namespace CherAmi
{
    public class ShellEngine
    {
        private bool _isRunning = true;

        private readonly CommandParser _parser = new CommandParser();

        private readonly CommandRouter _Router = new CommandRouter();

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
            _isRunning = _Router.Route(parsed);
        }
    }
}