namespace AbstractFactory
{
    public class Client
    {
        ISportsFactory sportsFactory;
        public Client(ISportsFactory sportsFactory)
        {
            this.sportsFactory = sportsFactory;
        }

        public string GetSportsDetails()
        {
            IGame game = sportsFactory.Game();
            IPlayer player = sportsFactory.Player();
            IDuration duration = sportsFactory.Duration();
            return string.Format("Play {0} as {1} for {2} minutes", game.GetGame(), player.GetPlayer(), duration.GetDuration());
        }

    }
}
