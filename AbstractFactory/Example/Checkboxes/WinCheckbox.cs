namespace AbstractFactory.Example.Checkboxes;

// Concrete products are created by corresponding concrete
// factories.
public class WinCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Render a checkbox in Windows style.");
    }
}