namespace TriviaGame
{
    internal class Game
    {
        private Player? _currentPlayer;
        private readonly TriviaItem[] _QA;
        private readonly string _titleArt = @"
  _______   _       _          ____                  _   
 |__   __| (_)     (_)        / __ \                | |  
    | |_ __ ___   ___  __ _  | |  | |_   _  ___  ___| |_ 
    | | '__| \ \ / / |/ _` | | |  | | | | |/ _ \/ __| __|
    | | |  | |\ V /| | (_| | | |__| | |_| |  __/\__ \ |_ 
    |_|_|  |_| \_/ |_|\__,_|  \___\_\\__,_|\___||___/\__|
                                                         
                                                         
";
        private readonly string _gameTitle = "Trivia Quest";
        private readonly string _gameDescription = "Solve the trivia for better score.";

        public Game()
        {
            _QA = new TriviaItem[10]
            {
               new TriviaItem("What was Meta Platforms Inc formerly known as?", "Facebook"),
               new TriviaItem("Which element is said to keep bones strong?", "Calcium"),
               new TriviaItem("What does CIA stand for?", "Central Intelligence Agency"),
               new TriviaItem("Haematology is the study of what?", "The blood"),
               new TriviaItem("Rojo is the Spanish word for which colour?", "Red"),
               new TriviaItem("How many rings is the Olympic symbol made up of?", "Five"),
               new TriviaItem("Pyrophobia is the fear of what?", "Fire"),
               new TriviaItem("The logo for luxury car maker Porsche features which animal?", "Horse"),
               new TriviaItem("Which former British colony was given back to China in 1997?", "Hong Kong"),
               new TriviaItem("Randall Flag, Jack Torrance and John Coffey are all characters created by which author?", "Stephen King"),
            };
        }

        public void Play()
        {
            /*! The CLI app title */
            Console.Title = _gameTitle;
            
            /*! The welcome screen */
            Console.WriteLine(_titleArt);
            Console.WriteLine(_gameDescription);

            /*! Player registration */
            Console.Write("What's your name? ");
            string? playerName = Console.ReadLine();
            while (string.IsNullOrEmpty(playerName) || string.IsNullOrWhiteSpace(playerName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid input. Please write your name.");
                Console.ResetColor();
                Console.Write("> ");
                playerName = Console.ReadLine();
            }
            _currentPlayer = new Player(playerName);
            Console.WriteLine($"\nWelcome to {_gameTitle}, {_currentPlayer.Name}");
            Console.WriteLine($"Your current Score: {Player.Score}");

            /*! Game start */
            foreach(TriviaItem qa in _QA)
            {
               Console.WriteLine("\n-------------------------------------------------------");
               qa.DisplayQuestion();
               Console.WriteLine("-------------------------------------------------------");
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"You Scored: {Player.Score}");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\nHope you enjoy it :)\nSee you in another game!");
            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
