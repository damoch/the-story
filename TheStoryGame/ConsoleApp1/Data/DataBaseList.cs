using ConsoleApp1;
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
                        new DataBaseEntry()
                        {
                            Tags = new List<string>{"dowody",   },
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
                },
            #endregion
            #region JoannaKucharskaPrivateServer
                                new DataBase()
                {
                    IPAddr = "155.209.69.182",
                    Users = new List<DataBasePass>()
                    {
                        new DataBasePass("jkucharska", "aauBwb")
                    },
                    Name = "Prywatny serwer Joanny Kucharczyk",
                    Entries = new List<DataBaseEntry>()
                    {

                         new DataBaseEntry()
                        {
                            Tags = new List<string>{"praca", "palanice"  },
                            Title = "Wywiad, dokończyć transkrypcję",
                            Content = @"
JA: Co pan widział w lesie?
ŚWIADEK: Jakieś... Bo ja wiem? Miejsce kultu?
J: Po czym pan to poznał?
Ś: Stały tam (pokazuje palcem) jakieś pochodnie. Dodatkowo ścięli drzewo i zrobili z nim coś, co przypominało prowizoryczny ołtarz
J: Były może jakieś relikwie?
Ś: Wydaje się, że zabezpieczyła je policja. Podobno była na nich krew",
                            Date = new DateTime(1994,6,22),
                            ReadSpookyAdd = 10,
                            OnRead = () => {
                                Program.GameController.AddEmail(new Email()
                                {
                                    Sender = "security@guardsoft.com",
                                    Subject = "Urgent security info for all GuardianOS 93 users",
                                    ReceivedDate =  new DateTime(1994, 06, 26, 19, 1, 2),
                                    Content = @"Dear Zahary Bowen,
We are sorry to inform you about serious security issue in current version of GuardianOS 93. Our engineers are still in process of gathering info about this issue, all we know right now, is that hackers can
execute their code on every GuardianOS 93 remotely. Luckilly, it requires very specific action. 
Our team will try to roll out the patch ASAP. For now, we ecourage being carefull while interacting with the web. Don't install software of unknown origin.

Sincerely,
GuardSoft - Security Team", SpookyAdd = 15
                                });
                            }

                        },
                         new DataBaseEntry()
                        {
                            Tags = new List<string>{"praca",  },
                            Title = "Notatka",
                            Content = @"
Muszę się dowiedzieć więcej o tym spotkaniu kultu. Na serwerze dziennika (16.151.26.247 ten sam login i hasło) zapisałam dane, które udało mi się wyciągnąć od mojego informatora w policji. Zapisałam pod tagiem 'dowody'",
                            Date = new DateTime(1994,6,22),
                            ReadSpookyAdd = 8
                            

                        },

                    }
                },
            #endregion

        };

        public static DataBase GetDatabaseByIp(string ip)
        {
            return _dataBases.FirstOrDefault(x => x.IPAddr == ip);
        }
        
    }
}