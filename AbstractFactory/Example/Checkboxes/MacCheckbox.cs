namespace AbstractFactory.Example.Checkboxes;

// Concrete products are created by corresponding concrete
// factories.
public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Render a checkbox in MacOS style.");
    }
}