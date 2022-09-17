namespace AbstractFactory.Example.Buttons;

// Concrete products are created by corresponding concrete
// factories.
public class MacButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Render a button in MacOS style.");
    }
}