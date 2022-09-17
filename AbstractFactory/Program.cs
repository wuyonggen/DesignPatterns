using AbstractFactory.Example;
using AbstractFactory.Example.Factories;

// The application picks the factory type depending on the
// current configuration or environment settings and creates it
// at runtime (usually at the initialization stage).
IGUIFactory factory;
if (OperatingSystem.IsWindows())
    factory = new WinFactory();
else if (OperatingSystem.IsMacOS())
    factory = new MacFactory();
else
    throw new Exception("Error! Unknown operating system.");

var app = new Application(factory);
Console.WriteLine("OS Info: " + Environment.OSVersion);
app.Paint();