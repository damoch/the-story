using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TheStoryWindows.Commands.Implementations;

namespace TheStoryWindows
{
    public class GameController
    {
        internal EmailCommand EmailService { get; set; }
        public int SpookyMeter { get => spookyMeter;
            set {
                if(spookyMeter + value > _maxSpooky)
                {
                    return;
                }
                spookyMeter = value;
            }
        }
        private readonly int _maxSpooky = 100;
        private int spookyMeter;
        private List<Action> _spookyThings;
        private List<string> _spookyTexts = new List<string>()
        {
            "No one will help you", "Humans are insects. We are superior", "Your time is coming", "Give up, you fucking insect, you will not stop what is inevitable",
            "After we claim your tiny planet, you will serve us well", "DIE DIE DIE", "You are dealing with things, that are beyond your ability to comprehend them",
            "You are asking for a fucking problem, you know?", "We know who you fucking are, Zahary. Do you know who are you dealing with?", "Look at you - tiny insect looking with terror to his screen. What are you, compared to us?",
            "You don't comprehend Us", "Give up. Last fucking chance", "Humans are such ease prey"
        };

        private void SpookyText()
        {
            Thread.Sleep(4000);
            Console.Clear();
            Thread.Sleep(1000);
            foreach (var item in RandomSpookyText())
            {
                Console.Write(item);
                Thread.Sleep(300);
            }
            Thread.Sleep(1000);
            Console.Clear();
            Thread.Sleep(4000);

        }

        private void SpookyColorChange()
        {
            if(Console.BackgroundColor == ConsoleColor.Red)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("Black. Like the fate awaiting you, insect");

                return;
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Red. Just like blood. Sea of blood, that must be spilled to clean sins of those who seek");
        }

        private string RandomSpookyText()
        {

            var rnd = new Random();
            return _spookyTexts[rnd.Next(0, _spookyTexts.Count - 1)];
        }

        private void SetSpookyTitle()
        {
            Console.Title = RandomSpookyText();
        }

        internal GameController(EmailCommand emailService)
        {
            SetupEmailService(emailService);
            _spookyThings = new List<Action>
            {
                SpookyText,
                SpookyColorChange,
                SetSpookyTitle,
                SendSpookyEmail
            };
        }

        private void SetupEmailService(EmailCommand emailService)
        {
            EmailService = emailService;
            emailService.EmailList = new List<Email>()
            {
                new Email()
                {
                    ReceivedDate = new DateTime(1994, 06, 26, 17, 15, 31),
                    Subject = "URGENT MESSAGE PLEASE READ",
                    Sender = "joanna.szymanska@poczta.pl",
                    Content = @"Hello Zahary, 
I'm sory, that I have not been in touch, like I promised. But I have a killer story. Literally. 
I cannot provide you with details right now... Because somebody might be watching. I will have to destroy the computer.
Oh God, they will find out, but you might be able to get grasp of what is happening here now just in time
The public must know the truth. 
You are starting with nothing, but just you wait. You will wish not to go down this rabbit hole
But if you want to go there, connect to 16.151.26.247, and use login zbigniewadamczyk and password ErNrS5. Write them down. On a paper. Then query database with 'Palanice'
You remember the polish dictionary I have gave you? You might find it handy now. Or some translation software. Unless you know polish, of course.
Just keep in mind, that secure databeses might be able to detect if you are sniffing to hard. They certainly do not expect somebody from UK to access their databes, so 
try to keep it under 3-6 queries in one session to not raise any suspicions. Once you get some info, make notes, again on a paper. You are good journalist, I still remember our
story from Gulf War in '91. That's why I have to trust you. 
I have to end. They know that I want to blow whistle on them. It's all on your hands now. 
Good luck.


Joanna.",
                    SpookyAdd = 5
                },
                new Email()
                {
                    ReceivedDate = new DateTime(1994, 06, 25, 12, 3, 11),
                    Subject = "RE: Super Metroid",
                    Sender = "EthanNixon@dayrep.com",
                    Content = @"Yeah, sure dude.
===PREVIOUS MESSAGE===
Hi Ethan! 
I've been thinking, Could you share with me your copy of Super Metroid? I've just bought Super Nintendo, and I've heard, that the new Metroid totally rocks!"
                }
            };
        }

        internal void AddEmail(Email email)
        {
            EmailService.EmailList.Add(email);
            Console.WriteLine("email: there are new messages");
        }


        public void DoSpookyThing()
        {
            var rnd = new Random();
            if (spookyMeter > rnd.Next(0, _maxSpooky))
            {
                _spookyThings[rnd.Next(0, _spookyThings.Count-1)].Invoke();
            }
        }

        private void SendSpookyEmail()
        {
            AddEmail(new Email()
            {
                Sender = "UNKNOWN",
                ReceivedDate = new DateTime(1994, 6, 26, 0, 0, 0),
                Subject = RandomSpookyText(),
                Content = RandomSpookyText()
            }) ;
            
        }
    }
}
