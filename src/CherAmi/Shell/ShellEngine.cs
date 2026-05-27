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

            var context = new ShellContext();
            context.IsRunning = true;

            while (context.IsRunning)
            {
                Console.Write("CherAmi@shell> ");
                string input = Console.ReadLine();

                HandleInput(input, context);
            }



        }

        private void HandleInput(string input, ShellContext context)
        {

            

            ParsedCommand parsed = _parser.Parse(input);
            _Router.Route(parsed, context);
        }


    }

    public class ShellContext
    {
           public bool IsRunning { get; set; }
    }
}