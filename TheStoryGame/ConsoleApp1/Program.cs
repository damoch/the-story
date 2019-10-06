using System;
using System.Threading;
using TheStoryWindows;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;
using TheStoryWindows.Commands.Implementations;

namespace ConsoleApp1
{
    class Program
    {
        private static GameController _gameController;

        public static GameController GameController { get => _gameController; }

        static void Main(string[] args)
        {
            SetupGame();
#if !DEBUG
            SimulateOSStart();
#endif
            while (true)
            {
                DecodeCommand(CommandPrompt());
            }
        }

        private static void SetupGame()
        {
            _gameController = new GameController((EmailCommand)CommandBase.GetByIdentifier(CommandIdentifier.email.ToString()));
        }

        private static void DecodeCommand(string command)
        {
            _gameController.DoSpookyThing();
            var commTab = command.Split(' ');
            var commName = commTab[0];

            try
            {
                var cmd = CommandBase.GetByIdentifier(commName);
                var param = commTab.Length > 1 ? commTab[1] : null;
                cmd.Execute(param);
            }
            catch
            {
                Console.WriteLine("Unknown command {0}", commName);
            }
        }

        private static void SimulateOSStart()
        {
            var rnd = new Random();
            Console.Write("Booting GuardianOS 93 by GuardSoft");
            for (int i = 0; i < rnd.Next(2, 8); i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("MemoryTest: OK");
            Console.Write("Logging in");
            for (int i = 0; i < rnd.Next(2, 8); i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("Hello ZacharyBowen!");
            Console.Write("Trying to connect to the web");
            for(int i = 0; i < rnd.Next(2, 8); i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            Console.WriteLine("Connection: OK");
            Console.WriteLine("Starting command prompt");
            Thread.Sleep(500);
            Console.WriteLine("OK!");
            Console.WriteLine("Type 'help' to get list of commands");
            Console.WriteLine("email: there are new messages");
        }

        private static string CommandPrompt()
        {
            Console.Write(">>> ");
            return Console.ReadLine();
        }
    }
}
