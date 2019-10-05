using System;
using System.Collections.Generic;
using System.Text;
using TheStoryWindows.Commands.Implementations;

namespace TheStoryWindows
{
    public class GameController
    {
        internal EmailCommand EmailService { get; set; }

        internal GameController(EmailCommand emailService)
        {            
            SetupEmailService(emailService);
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


Joanna."
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
    }
}
