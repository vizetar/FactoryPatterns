namespace AbstractFactory
{
    public class Individual : IPlayer
    {
        public string GetPlayer()
        {
            return Players.Individual.ToString();
        }
    }

    public class Team : IPlayer
    {
        public string GetPlayer()
        {
            return Players.Team.ToString();
        }
    }
}
