using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISportsFactory factory = new SportsFactory();
            ISports sports = factory.GetSports(SportsType.Indoor);
            sports.Play();
            sports.Exit();
            Console.ReadLine();
        }
    }
}
