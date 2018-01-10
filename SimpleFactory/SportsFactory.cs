using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public interface ISportsFactory
    {
        ISports GetSports(SportsType sportsType);
    }

    public class SportsFactory : ISportsFactory
    {
        public ISports GetSports(SportsType sportsType)
        {
            switch(sportsType)
            {
                case SportsType.Indoor:
                    return new Indoor();
                case SportsType.Outdoor:
                    return new Outdoor();
                default:
                    return new Indoor();
            }
        }
    }
}
