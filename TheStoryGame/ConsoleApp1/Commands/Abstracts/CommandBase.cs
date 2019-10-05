using System;
using System.Collections.Generic;
using TheStoryWindows.Commands.Enums;
using TheStoryWindows.Commands.Implementations;

namespace TheStoryWindows.Commands.Abstracts
{
    internal abstract class CommandBase
    {
        private static Dictionary<CommandIdentifier, CommandBase> _implementations = new Dictionary<CommandIdentifier, CommandBase> { { CommandIdentifier.help, new HelpCommand() } };
        public abstract CommandIdentifier Idetifier { get; }
        public abstract string Description { get; }

        public abstract void Execute(string param = null);

        public static CommandBase GetByIdentifier(string identifier)
        {
            try
            {
                var enumVal = (CommandIdentifier)Enum.Parse(typeof(CommandIdentifier), identifier);
                return _implementations[enumVal];

            }
            catch
            {
                return null;
            }
        }
    }
}
