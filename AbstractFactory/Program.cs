using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISportsFactory sportsFactory = new SportsFactory().Create(SportsType.Indoor);
            Client client = new Client(sportsFactory);
            Console.WriteLine(client.GetSportsDetails());
            Console.ReadLine();
        }
    }
}
