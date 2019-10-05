﻿using System;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;

namespace TheStoryWindows.Commands.Implementations
{
    internal class ShutdownCommand : CommandBase
    {
        public override CommandIdentifier Identifier => throw new NotImplementedException();

        public override string Description => "Shuts down computer. No parameters.";

        public override void Execute(string param = null)
        {
            Console.WriteLine("Good bye!");
            System.Threading.Thread.Sleep(3000);
            Environment.Exit(0);
        }
    }
}
