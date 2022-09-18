namespace Strategy.Example.Strategies;

public class ConcreteStrategySubtract : IStrategy
{
    public int Execute(int a, int b)
    {
        return a - b;
    }
}