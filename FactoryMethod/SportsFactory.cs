using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class SportsFactory 
    {
        public BaseFactory CreateFactory(SportsType sportsType)
        {
            switch (sportsType)
            {
                case SportsType.Indoor:
                    return new IndoorFactory();
                case SportsType.Outdoor:
                    return new OutdoorFactory();
                default:
                    return new IndoorFactory();
            }
        }
    }
}
