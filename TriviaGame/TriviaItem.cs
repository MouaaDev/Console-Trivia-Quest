namespace TriviaGame
{
    internal class TriviaItem
    {
        private readonly string _question;
        private readonly string _answer;

        public TriviaItem(string question, string answer)
        {
            _question = question;
            _answer = answer;
        }

        public void DisplayQuestion()
        {
            Console.WriteLine(_question);
            Console.Write("What's your answer? ");
            string? answerText = Console.ReadLine();

            /*! Handling null errors */
            while (string.IsNullOrEmpty(answerText) || string.IsNullOrWhiteSpace(answerText))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please write your answer.");
                Console.ResetColor();
                Console.Write("> ");
                answerText = Console.ReadLine();
            }
            

            if (answerText.ToLower() == _answer.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct\n");
                Console.ResetColor();
                Player.Score++;
            }
            else if (answerText.ToLower() != _answer.ToLower())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong\n");
                Console.ResetColor();
                Console.WriteLine($"The correct answer is: {_answer}");
            }
        }
    }
}
