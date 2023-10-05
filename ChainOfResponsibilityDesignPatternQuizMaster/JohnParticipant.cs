using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternQuizMaster
{
    internal class JohnParticipant : ParticipantHandler
    {
        public JohnParticipant(string participantResponse) : base(participantResponse)
        {
        }

        protected override void WriteMessage()
        {
            Console.WriteLine("Good Job John !!");
        }
    }
}
