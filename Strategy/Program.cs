using Strategy.Example;
using Strategy.Example.Strategies;

Context ctx = new Context();

Console.WriteLine("Enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Choose an operation:" + "\n" +
                  "1 - addition" + "\n" +
                  "2 - subtraction" + "\n" +
                  "3 - multiplication");
int operation = Convert.ToInt32(Console.ReadLine());

if (operation == 1)
{
    ctx.SetStrategy(new ConcreteStrategyAdd());
} else if (operation == 2)
{
    ctx.SetStrategy(new ConcreteStrategySubtract());
} else if (operation == 3)
{
    ctx.SetStrategy(new ConcreteStrategyMultiply());
}

Console.WriteLine("\nThe result is :{0}", ctx.ExecuteStrategy(a, b));

                  