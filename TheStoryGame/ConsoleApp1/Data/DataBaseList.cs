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
#region TestBase
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
                    new DataBasePass("admin", "admin1")
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




            },
            
                #endregion TestBase 
            #region DziennikPalanickiBase
                new DataBase()
                {
                    IPAddr = "16.151.26.247",
                    Users = new List<DataBasePass>()
                    {
                        new DataBasePass("zbigniewadamczyk", "ErNrS5"), new DataBasePass("jkucharska", "aauBwb")
                    },
                    Name = "Baza danych Dziennika Palenickiego",
                    Entries = new List<DataBaseEntry>()
                    {
                        new DataBaseEntry()
                        {
                            Tags = new List<string>{"notatki", "palanice",  },
                            ReadSpookyAdd = 5,
                            Title = "Szkic artykułu o porwaniach",
                            Content = @"
Mamy nowe doniesienia o porwaniach mieszkańców naszej miejscowości. W czawartek uprowadzona zastała osiemdziesięcioletnia Monika K. mieszkająca na ulicy Jana Kazimierza. Lokalna policja rozkłada ręce - 
Tożsamości porywaczy pozostają nieznane. Ostatnia ofiara dołączyła do grupy ponad dziesięciu osób, które zniknąły w tajemniczych okolicznościach na przełomie maja i czerwca tego roku.", 
                            Date = new DateTime(1994,6,22)
                        },
                                                new DataBaseEntry()
                        {
                            Tags = new List<string>{"notatki",   },
                            Title = "Loginy USUŃMY TO, BO KTOŚ JE UKRADNIE",
                            Content = @"
login: zbigniewadamczyk
hasło: ErNrS5

login: jkucharska
hasło: aauBwb

jakby co to możesz wejść na mój prywatny serwer (155.209.69.182) tam mam wywiad dotyczący tej historii o porwaniach (wyszukaj Palanice). Login i hasło takie samo co tutaj",
                            Date = new DateTime(1994,6,22)
                        },

                    }
                }
#endregion
        };

        public static DataBase GetDatabaseByIp(string ip)
        {
            return _dataBases.FirstOrDefault(x => x.IPAddr == ip);
        }
        
    }
}