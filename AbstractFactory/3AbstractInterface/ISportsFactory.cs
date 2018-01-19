namespace AbstractFactory
{
    public interface ISportsFactory
    {
        IGame Game();
        IPlayer Player();
        IDuration Duration();
    }
}
