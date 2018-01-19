namespace AbstractFactory
{
    public class IndoorGameFactory : ISportsFactory
    {
        public IDuration Duration()
        {
            return new IndoorDuration();
        }

        public IGame Game()
        {
            return new Chess();
        }

        public IPlayer Player()
        {
            return new Individual();
        }
    }

  
}
