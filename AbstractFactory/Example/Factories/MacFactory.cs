using AbstractFactory.Example.Buttons;
using AbstractFactory.Example.Checkboxes;

namespace AbstractFactory.Example.Factories;

// Each concrete factory has a corresponding product variant.
public class MacFactory : IGUIFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}