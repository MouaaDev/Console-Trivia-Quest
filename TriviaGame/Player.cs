namespace TriviaGame
{
    internal class Player
    {
        public string Name { get; set; }
        public static int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
    }
}
