namespace AbstractFactory
{
    public class OutdoorGameFactory : ISportsFactory
    {
        public IDuration Duration()
        {
            return new OutdoorDuration();
        }

        public IGame Game()
        {
            return new Football();
        }

        public IPlayer Player()
        {
            return new Team();
        }
    }
}
