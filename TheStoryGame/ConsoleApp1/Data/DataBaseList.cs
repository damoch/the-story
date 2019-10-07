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
                            Tags = new List<string>{"notatki", "palenice",  },
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

jakby co to możesz wejść na mój prywatny serwer (155.209.69.182) tam mam wywiad dotyczący tej historii o porwaniach (wyszukaj palenice). Login i hasło takie samo co tutaj",
                            Date = new DateTime(1994,6,22)
                        },

                        new DataBaseEntry()
                        {
                            Tags = new List<string>{"dowody",   },
                            Title = "Login do policyjnej bazy",
                            Content = @"
zdobyłam login i hasło do policyjnej bazy danych, są niestety zaszyfrowane... 
aXA6IDI0Ny45NS4xMTguNTUKbG9naW46IEFtYWRldXN6Tm93YWsKaGFzbG86IHd3dTdOaWFzZA==
Możliwe, że na serwerze FreeSoftware (11.213.186.247, login 'guest' bez hasła) znajduje się jakieś deszyfrujące oprogramowanie. Sprawdzę tam tag 'decrypt'",
                            Date = new DateTime(1994,6,22),
                            ReadSpookyAdd = 20
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
                            Tags = new List<string>{"praca", "palenice"  },
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
            #region FreeSoftwareDataBase
            new DataBase()
            {
                Name = "FreeSoftware - where programs live free of capitalism",
                IPAddr = "11.213.186.247",
                Software = new List<CommandBase>()
                {
                    new DecoderCommand()
                },
                Users = new List<DataBasePass>()
                {
                    new DataBasePass("guest", "")
                },
                Entries = new List<DataBaseEntry>()
                {
                    new DataBaseEntry()
                    {
                        Title = "Decoder",
                        Date = new DateTime(1992, 2, 20),
                        Content = @"DECODER v2.137
Smart software, that decodes secret messages. No secret is safe!

INSTALLATION: installTool 11.213.186.247_decoder",
                        Tags = new List<string>()
                        {
                           "encryption", "software", "decrypt"
                        },
                        ReadSpookyAdd = 15,
                        OnRead = () =>
                        {
                            Program.GameController.AddEmail(new Email()
                            {

                                ReceivedDate = new DateTime(1994, 06, 26, 20, 15, 31),
                    Subject = "IT WAS ALL JOKE",
                    Sender = "joanna.szymanska@poczta.pl",
                    Content = @" 
HEY! I AM SO STUPID, JUST LIKE INSECT THAT I AM. HA HA HA, SO FUNNY
THERE IS NOTHING TO FEAR
EMBRACE THE NEW
SHUT DOWN THE COMPUTER DONT SEEK ANYMORE, MY PREVIOUS MESSAGE WAS FAKE HA HA HA

SERIOUSLY
DO IT
BYE",
                    SpookyAdd = 20
                            });
                                                        Program.GameController.AddEmail(new Email()
                            {

                                ReceivedDate = new DateTime(1994, 06, 26, 20, 15, 31),
                    Subject = "UFOs over Europe",
                    Sender = "toby.holloway@britishmail.com",
                    Content = @"Hello Zahary, 
Hey, you remember our chat about UFO's over Germany and Poland? I just saw one over Sheffield! 
Even more, my neighbour talked about weird figures, that gave him overwhelming sense of terror. Also, you remember that talk about some weird cultists? Well, it turns out, that there was some weird
balck mass type of shit. 
I don't know man. I hope my mom is doing okay, you check with your parents.

Stay safe,
Toby",
                    SpookyAdd = 5
                            });
                        }

                    }

                }

            },
            #endregion
            #region PoliceDataBase
            //247.95.118.55
                        new DataBase()
            {
                Name = "Policja Palenice",
                IPAddr = "247.95.118.55",
                Software = new List<CommandBase>()
                {
                    new ECMSCommand()
                },
                Users = new List<DataBasePass>()
                {
                    new DataBasePass("AmadeuszNowak", "wwu7Niasd")
                },
                Entries = new List<DataBaseEntry>()
                {
                    new DataBaseEntry()
                    {
                        Title = "Zaginieni w Palenicach:",
                        Date = new DateTime(1994, 6, 26, 23, 05, 01),
                        Content = @"
Joanna Szymańska - lat 29 - ZNALEZIONO CIAŁO
Sławomir Adamski - lat 36 - ZNALEZIONO CIAŁO
Malina Jabłońska - lat 77 - ZNALEZIONO CIAŁO
Luiza Dąbrowski - lat 70 
Konstanty Kalinowski - lat 33
Angelika Dudek - lat 28 - URATOWANA, PRZESŁUCHANA
Augustyna Nowakowska - LAT 21 - ZNALEZIONO CIAŁO
Maksymilian Kowalski - lat 56 
",
                        Tags = new List<string>()
                        {
                            "palenice", "angelika", "dudek"
                        },
                        ReadSpookyAdd = 15,
                        OnRead = () =>
                        {
                                                        Program.GameController.AddEmail(new Email()
                            {

                                ReceivedDate = new DateTime(1994, 06, 26, 20, 15, 31),
                    Subject = "I AM STILL ALIVE",
                    Sender = "joanna.szymanska@poczta.pl",
                    Content = @" 
HAHAHA SO FUNNY THESE POLICEMEN
Joanna Szymańska - lat 29 - ZNALEZIONO CIAŁO
HAHAHA IT WAS NOT ME I AM ALIVE AND OKAY YOU FUCKFACE
STOP THIS TUPID FUCKING THING 
JUST STOP
YOU MOTHERFUCKER
WE WILL FUCKING RAPE RAPE RAPE YOU",
                    SpookyAdd = 20
                            });
                        }
                    },
                     new DataBaseEntry()
                    {
                        Title = "Transkrypt przesłuchania Angeliki Dudek",
                        Date = new DateTime(2019, 10, 05, 23, 05, 01),
                        Content = @"
Prowadząca: inspektor Felicja Walczak
Felicja Walczak: Dzien dobry, Angeliko. Chciałabym zadać Ci parę pytań.
Angelika Dudek: (milczy)
FW: Czy pamiętasz tą noc kiedy cię uprowadzono?
AD: (milczy, patrzy przed siebie)
FW: Angeliko, wiem że to dla ciebie trudne. Ale wciąż są ludzie, którzy potrzebują naszej pomocy. Razem możemy im...
AD: Wszystko się skończy. Jesteśmy tylko insektami wobec ich potęgi.
FW: ... jakich 'ich'?
AD: Możesz już pożegnać Marcela i Damiana, twoje ukochane dzieci. Wszyscy zginiemy. Donis się obudzi
FW: Jakim cudem znasz... Znasz imiona moich dzieci?
AD: Jedyne co możesz zrobić, to dołączyć do Dominion i błagać ich o wybaczenie. Albo miec nadzieję, że o nas zapomną. Oni...
===Koniec Protokołu====
",
                        Tags = new List<string>()
                        {
                            "palenice", "donis", "dominion", "angelika", "dudek"
                        },
                        ReadSpookyAdd = 13

                    },
                                          new DataBaseEntry()
                    {
                        Title = "Donis i Dominion - raport",
                        Date = new DateTime(1994, 6, 26, 22, 05, 01),
                        Content = @"
Autor: inspektor Felicja Walczak
Sekta Dominion zaczęła swą działalność we wczesnych latach sześćdziesiątych. Mówimy tu o działalności jawnej, przypuszczamy, że działalność niejawna mogła trwać od kilkuset do kulku tysięcy lat.
Na początku podejrzewano, że sekta to grupa kilku wariatów czesto oddających się narkotykom, a sporadycznie popełniających gwałty i morderstwa. 
To założenie okazało się być błędne. Niestety.

Nie jesteśmy w stanie tego wyjaśnić, ale wygląda na to, że Donis (obekt wyznań kultu) istnieje. Kontaktujemy się z instytucjami naukowymi, ale one też rozkładają ręce
Moja sugestia jest następująca: ogłosić stan wyjątkowy i postawić wszytskie służby w stan gotowości. I przygotować się na najgorsze",
                        Tags = new List<string>()
                        {
                             "donis", "dominion"
                        },
                        ReadSpookyAdd = 28,
                                                OnRead = () =>
                        {
                                                        Program.GameController.AddEmail(new Email()
                            {

                                ReceivedDate = new DateTime(1994, 06, 26, 23, 56, 31),
                    Subject = "GOODBYE",
                    Sender = "true.joanna.szymanska@poczta.pl",
                    Content = @" 
Hey
If you are reading this email, I am dead. 

It's my last chance effort. If this fails, humanity is doomed. That is the last way to stop Donis
aW5zdGFsbFRvb2wgNDYuMTM0LjcwLjE4X2Rvbmlz",
                    SpookyAdd = 20
                            });
                        }
                    }


                }

            },
            #endregion
                        new DataBase()
                        {
                            IPAddr = "46.134.70.18",
                            Software = new List<CommandBase>()
                            {
                                new DonisCommand()
                            }
                        }

        };

        public static DataBase GetDatabaseByIp(string ip)
        {
            return _dataBases.FirstOrDefault(x => x.IPAddr == ip);
        }
        
    }
}