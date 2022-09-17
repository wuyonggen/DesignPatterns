namespace AbstractFactory.Example.Buttons;

// Concrete products are created by corresponding concrete
// factories.
public class WinButton : IButton
{
    public void Paint()
    {
        Console.WriteLine("Render a button in Windows style.");
    }
}