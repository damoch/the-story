using System;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;

namespace TheStoryWindows.Commands.Implementations
{
    internal class HelpCommand : CommandBase
    {
        public override CommandIdetifier Idetifier => CommandIdetifier.help;

        public override void Execute(string param = null)
        {
            foreach (var item in Enum.GetValues(typeof(CommandIdetifier)))
            {
                Console.WriteLine(item);
            }
        }
    }
}
