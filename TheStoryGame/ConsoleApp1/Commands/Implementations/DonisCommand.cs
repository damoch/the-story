using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;

namespace TheStoryWindows.Commands.Implementations
{
    internal class DonisCommand : CommandBase
    {
        public override CommandIdentifier Identifier => CommandIdentifier.donis;

        public override string Description => "";

        public override void Execute(string param = null)
        {
            Thread.Sleep(5000);
            Program.GameController.PlaySpookySound();
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            var str1 = "WELCOME TO YOUR DOOM";
            foreach (var item in str1)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Thread.Sleep(1000);
            Console.Clear();
            var str2 = "INSECT";
            Program.GameController.PlaySpookySound();
            foreach (var item in str2)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Thread.Sleep(1000);
            Console.Clear();
            var str3 = "YOU WERE JUST A PUPPET TO US. NOW WE ARE READY TO CLAIM YOUR PATHETIC LITTLE PLANET. YOUR WILL SERVE US WELL AS A SLAVE.";
            foreach (var item in str3)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Program.GameController.PlaySpookySound();
            var str4 = "NO ONE CAN STOP US";
            foreach (var item in str4)
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Program.GameController.PlaySpookySound();
            Thread.Sleep(5000);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();


            Console.WriteLine(@"
Thanks for playing The Story
Press any key to exit

Kszaku - 2019");

            Console.ReadKey();

            Environment.Exit(0);
        }
    }
}
