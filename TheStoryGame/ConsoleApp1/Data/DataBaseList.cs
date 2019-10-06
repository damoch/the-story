using System;
using System.Collections.Generic;
using System.Linq;
using TheStoryWindows.Commands.Abstracts;
using TheStoryWindows.Commands.Implementations;

namespace TheStoryWindows.Data
{
    internal partial class DataBase
    {
        private static List<DataBase> _dataBases = new List<DataBase>()
        {
            new DataBase()
            {
                Name = "TestBase",
                IPAddr = "6.6.6.6",
                Software = new List<CommandBase>()
                {
                    new ECMSCommand()
                },
                Users = new List<DataBasePass>()
                {
                    new DataBasePass()
                    {
                        Login = "admin",
                        Password = "admin1"
                    }
                },
                Entries = new List<DataBaseEntry>()
                {
                    new DataBaseEntry()
                    {
                        Title = "Test note",
                        Date = new DateTime(2019, 10, 05, 23, 05, 01),
                        Content = @"This is a test note
this is only a test
Dont worry",
                        Tags = new List<string>()
                        {
                            "test", "testing"
                        },

                    }

                }

            }
        };

        public static DataBase GetDatabaseByIp(string ip)
        {
            return _dataBases.FirstOrDefault(x => x.IPAddr == ip);
        }
        
    }
}