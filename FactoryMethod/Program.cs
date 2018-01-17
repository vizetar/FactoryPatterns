using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseFactory factory = new SportsFactory().CreateFactory(SportsType.Outdoor);
            factory.DisplayResult();
            Console.ReadLine();
        }
    }
}
