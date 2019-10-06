using System;
using System.Linq;
using System.Threading;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;
using TheStoryWindows.Data;

namespace TheStoryWindows.Commands.Implementations
{
    internal class InstallToolCommand : CommandBase
    {
        private DataBase _currentDataBase;

        public override CommandIdentifier Identifier => CommandIdentifier.installTool;

        public override string Description => "Installs software from the web. Usage installTool ipAddr_softwareName";

        public override void Execute(string param = null)
        {
            if(param == null)
            {
                Console.WriteLine("ipAdrr required");
                return;
            }
            var opts = param.Split('_');
            if (opts.Length != 2)
            {

                Console.WriteLine("Parametr must be in format ipAddrr_softwareName");
                return;
            }
            var ip = opts[0];
            var commName = opts[1];
            var rnd = new Random();
            Console.Write("Connecting to {0}", ip);
            for (int i = 0; i < rnd.Next(2, 8); i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            _currentDataBase = DataBase.GetDatabaseByIp(ip);
            if (_currentDataBase == null)
            {
                Console.WriteLine("Failed to connect to {0}. Are you sure that IP is correct?", ip);
                return;
            }

            Console.WriteLine("Connected to {0}", ip);
            try
            {
                Console.Write("Seeking for manifest of {0}", commName);
                for (int i = 0; i < rnd.Next(2, 8); i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                var cmdEnumValue = (CommandIdentifier)Enum.Parse(typeof(CommandIdentifier), commName);
                var commmand = _currentDataBase.Software.FirstOrDefault(x => x.Identifier == cmdEnumValue);
                if(commmand == null)
                {
                    throw new Exception();
                }
                Console.WriteLine("Installing {0}", commName);


                for (int i = 0; i < rnd.Next(2, 16); i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                AddCommand(commmand);
                Console.WriteLine("Succesfull!");

            }
            catch
            {
                Console.WriteLine("Failed to install {0} from {1}. There is no software with coresponding name",commName, ip);
            }
            finally
            {
                _currentDataBase = null;

            }
        }
    }
}
