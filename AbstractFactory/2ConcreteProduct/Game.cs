namespace AbstractFactory
{
    public class Chess : IGame
    {
        public string GetGame()
        {
            return Games.Chess.ToString();
        }
    }

    public class Football : IGame
    {
        public string GetGame()
        {
            return Games.Football.ToString();
        }
    }
}
