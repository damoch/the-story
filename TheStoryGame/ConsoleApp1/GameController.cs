using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TheStoryWindows.Commands.Abstracts;
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
        private bool _emailNewMessages;

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
            PlaySpookySound();
            Console.Clear();
            Thread.Sleep(4000);

        }

        private void SpookyColorChange()
        {
            Console.Beep();
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

        public void ChceckEmail()
        {
            if (_emailNewMessages)
            {
                Console.WriteLine("email: there are new messages");
                _emailNewMessages = false;
            }
        }

        public void PlaySpookySound()
        {
            var rnd = new Random();
            for (var i = 0; i< rnd.Next(5,9); i++)
            {
                Console.Beep(rnd.Next(166, 415), rnd.Next(100, 1600));
            }
        }

        private void SetSpookyTitle()
        {
            PlaySpookySound();
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
                SendSpookyEmail,
                PlaySpookySound
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
But if you want to go there, connect to 16.151.26.247, and use login zbigniewadamczyk and password ErNrS5. Write them down. On a paper. Then query database with 'Palenice'
You remember the polish dictionary I have gave you? You might find it handy now. Or some translation software. Unless you know polish, of course.
Just keep in mind, that secure databeses might be able to detect if you are sniffing to hard. They certainly do not expect somebody from UK to access their databes, so 
try to keep it under 3-6 queries in one session to not raise any suspicions. Once you get some info, make notes, again on a paper. You are good journalist, I still remember our
story from Gulf War in '91. That's why I have to trust you. 
I have to end. They know that I want to blow whistle on them. It's all on your hands now. 
Good luck.


Joanna.",
                    SpookyAdd = 8
                },
                new Email()
                {
                    ReceivedDate = new DateTime(1994, 06, 25, 12, 3, 11),
                    Subject = "RE: Super Metroid",
                    Sender = "EthanNixon@dayrep.com",
                    Content = @"Yeah, sure dude.

----
Ethan Nixon
IT Dept Director at Daily Report
===PREVIOUS MESSAGE===
Hi Ethan! 
I've been thinking, Could you share with me your copy of Super Metroid? I've just bought Super Nintendo, and I've heard, that the new Metroid totally rocks!

-----
Best Wishes,
Zahary Bowen
Senior Reporter at Daily Report"
                },
                new Email()
                {
                    ReceivedDate = new DateTime(1994, 06, 24, 7, 3, 5),
                    Subject = "Hey!",
                    Sender = "eliseOconnor@dayrep.com",
                    Content = @"Good to have you back! How was your holiday?
I hope, that you could use that sweet, post holiday energy to deliver some amazing story for the next issue!
Also, there was woman from Poland, who tried to call you. She said it was reaaly urgent. Yeah, I remembered your 'no phone on holidays' policy, so I gave her your email address.

---
With regards:
Elise O'Connor
Chief Editor at Daily Report"
                }
            };
        }

        internal void AddEmail(Email email)
        {
            EmailService.EmailList.Add(email);
            _emailNewMessages = true;
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
