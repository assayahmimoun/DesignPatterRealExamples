namespace ChainOfResponsibilityDesignPatternQuizMaster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var johnParticipant = new JohnParticipant("Internet Protocol");
            var davidParticipant = new DavidParticipant("Transmission Control Protocol");
            var rajParticipant = new RajParticipant("User Datagram Protocol");
            johnParticipant.SetNext(davidParticipant);
            davidParticipant.SetNext(rajParticipant);
            var firstQuestion = new Question()
            {
                Libelle = "What is mean IP ?",
                CorrectAnswer = "Internet Protocol"
            };
            johnParticipant.Validate(firstQuestion);
            var secondQuestion = new Question()
            {
                Libelle = "What is mean TCP ?",
                CorrectAnswer = "Transmission Control Protocol"
            };
            johnParticipant.Validate(secondQuestion);
            var thirdQuestion = new Question()
            {
                Libelle = "What is mean UDP ?",
                CorrectAnswer = "User Datagram Protocol"
            };
            johnParticipant.Validate(thirdQuestion);
            Console.ReadLine();
        }
    }
}