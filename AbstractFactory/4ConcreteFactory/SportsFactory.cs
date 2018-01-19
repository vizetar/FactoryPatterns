namespace AbstractFactory
{
    public class SportsFactory
    {
        public ISportsFactory Create(SportsType sportsType)
        {
            switch(sportsType)
            {
                case SportsType.Indoor:
                    return new IndoorGameFactory();
                case SportsType.Outdoor:
                    return new OutdoorGameFactory();
                default:
                    return new IndoorGameFactory();
            }
        }
    }
}
