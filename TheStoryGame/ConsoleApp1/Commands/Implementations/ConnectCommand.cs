using System;
using System.Threading;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Enums;
using TheStoryWindows.Data;

namespace TheStoryWindows.Commands.Implementations
{
    internal class ConnectCommand : CommandBase
    {
        private DataBasePass _currentUser;
        private DataBase _currentDataBase;
        private int _queryLimit;

        public override CommandIdentifier Identifier => CommandIdentifier.connect;

        public override string Description => "Establishes connection to a web server. Usage: connect ip_address";

        public override void Execute(string param = null)
        {
            if(param == null)
            {
                Console.WriteLine("ip_address required");
                return;
            }

            var rnd = new Random();
            Console.Write("Connecting to {0}", param);
            for (int i = 0; i < rnd.Next(2, 8); i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }
            _currentDataBase = DataBase.GetDatabaseByIp(param);
            if(_currentDataBase == null)
            {
                Console.WriteLine("Failed to connect to {0}. Are you sure that IP is correct?", param);
                return;
            }

            Console.WriteLine("Connection succesfull");
            if (!Authenticate(_currentDataBase))
            {
                _currentUser = null;
                _currentDataBase = null;
                Console.WriteLine("Authentication failed!");
                return;
            }
            if (_currentUser.IsLocked)
            {
                _currentUser = null;
                _currentDataBase = null;
                Console.WriteLine("This user is locked! Contact database admin for more info");
                return;
            }
            Console.WriteLine("Welcome {0}!", _currentUser.Login);
            Console.WriteLine("Please enter your query bellow, or type exit to leave:");
            _queryLimit = rnd.Next(5, 10);
            while (HandleUserQueries()) ;
            _currentDataBase = null;
            _currentUser = null;
            Console.WriteLine("Goodbye!");
        }

        private bool HandleUserQueries()
        {
            Console.Write("{0}@{1}: ", _currentUser.Login, _currentDataBase.IPAddr);
            var query = Console.ReadLine().ToLower();
            if(query == "exit")
            {
                return false;
            }
            Console.WriteLine(_currentDataBase.Query(query));
            if(--_queryLimit == 0)
            {
                Console.WriteLine("Security incident detected. Connection terminated by server. Contact server admin for more info");
                _currentUser.IsLocked = true;
                return false;
            }
            return true;
        }

        private bool Authenticate(DataBase db)
        {
            Console.Write("Login: ");
            var login = Console.ReadLine();
            _currentUser = db.GetUser(login);
            if (_currentUser == null)
            {
                Console.WriteLine("User {0} doesn't exist!", login);
                return false;
            }

            Console.Write("Password: ");

            return _currentUser.Password == Console.ReadLine();
        }
    }
}
