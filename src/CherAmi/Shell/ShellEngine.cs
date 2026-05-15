namespace CherAmi
{
    public class ShellEngine
    {
        private bool _isRunning = true;

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
            if (string.IsNullOrWhiteSpace(input))
            {
                return;
            }

            if (input == "exit")
            {
                _isRunning = false;
                Console.WriteLine("Shutting down CherAmi...");
                return;
            }

            Console.WriteLine($"Unknown command: {input}");
        }
    }
}