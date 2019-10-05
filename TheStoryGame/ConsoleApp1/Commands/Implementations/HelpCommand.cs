using System;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;

namespace TheStoryWindows.Commands.Implementations
{
    internal class HelpCommand : CommandBase
    {
        public override CommandIdentifier Idetifier => CommandIdentifier.help;

        public override string Description => "Provides info about command. Usage: 'help commandName'";

        public override void Execute(string param = null)
        {
            if(param == null)
            {
                Console.WriteLine(Description);

                foreach (var item in Enum.GetValues(typeof(CommandIdentifier)))
                {
                    Console.WriteLine(item);
                }
                return;
            }
            var cmd = GetByIdentifier(param);
            if(cmd == null)
            {
                Console.WriteLine("Unknown command {0},", param);
            }
            Console.WriteLine(cmd.Description);
        }
    }
}
