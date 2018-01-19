using System;

namespace AbstractFactory
{
    public class IndoorDuration : IDuration
    {
        public string GetDuration()
        {
            return Durations.Thirty.ToString();
        }
    }

    public class OutdoorDuration : IDuration
    {
        public string GetDuration()
        {
            return Durations.Sixty.ToString();
        }
    }
}
