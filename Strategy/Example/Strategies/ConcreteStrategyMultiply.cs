namespace Strategy.Example.Strategies;

public class ConcreteStrategyMultiply : IStrategy
{
    public int Execute(int a, int b)
    {
        return a * b;
    }
}