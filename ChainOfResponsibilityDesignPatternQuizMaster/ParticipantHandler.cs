using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDesignPatternQuizMaster
{
    internal abstract class ParticipantHandler
    {
        protected ParticipantHandler? nextParticipant;

        protected ParticipantHandler(string response)
        {
            Response = response;
        }

        protected string Response { get; set; }
        
        public void SetNext(ParticipantHandler next)
        {
            this.nextParticipant = next;
        }

        public bool Validate(Question question)
        {
            if (Response == question.CorrectAnswer)
            {
                WriteMessage();
                return true;
            }

            return nextParticipant?.Validate(question) ?? false;
        }

        protected abstract void WriteMessage();
    }
}
