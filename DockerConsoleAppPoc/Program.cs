using System;

namespace DockerConsoleAppPoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArgumentApp is running...");
            while (true)
            {
                Console.Write("Enter arguments (type 'exit' to quit): ");
                var input = Console.ReadLine();
                if (input.ToLower() == "exit")
                {
                    break;
                }
                var arguments = input.Split(' ');
                Console.WriteLine("Arguments received:");
                foreach (var arg in arguments)
                {
                    Console.WriteLine(arg);
                }
            }
        }
    }
}
