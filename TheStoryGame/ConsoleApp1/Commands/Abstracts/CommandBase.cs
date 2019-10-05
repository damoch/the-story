using System.Collections.Generic;
using TheStoryWindows.Commands.Enums;
using TheStoryWindows.Commands.Implementations;

namespace TheStoryWindows.Commands.Abstracts
{
    internal abstract class CommandBase
    {
        private static Dictionary<CommandIdetifier, CommandBase> _implementations = new Dictionary<CommandIdetifier, CommandBase> { { CommandIdetifier.help, new HelpCommand() } };
        public abstract CommandIdetifier Idetifier { get; }

        public abstract void Execute(string param = null);

        public static CommandBase GetByIdentifier(CommandIdetifier identifier)
        {
            return _implementations[identifier];
        }
    }
}
