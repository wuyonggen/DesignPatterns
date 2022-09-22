using Prototype.Example;

var shapes = new List<Shape>();

Circle circle = new()
{
    X = 10,
    Y = 10,
    Radius = 20
};
shapes.Add(circle);

Circle anotherCircle = (Circle)circle.Clone();
shapes.Add(anotherCircle);

Rectangle rectangle = new()
{
    Width = 10,
    Height = 20
};
shapes.Add(rectangle);

var shapesCopy = new List<Shape>();
foreach (Shape s in shapes)
{
    shapesCopy.Add(s.Clone());
}

for (int i = 0; i < shapes.Count; i++)
{
    if (!ReferenceEquals(shapes[i], shapesCopy[i]))
    {
        Console.WriteLine(i + ": Shapes are different objects (yay!)");
        if (shapes[i].Equals(shapesCopy[i]))
        {
            Console.WriteLine(i + ": And they are identical (yay!)");
        }
        else
        {
            Console.WriteLine(i + ": But they are not identical (booo!)");
        }
    }
    else
    {
        Console.WriteLine(i + ": Shape objects are the same (booo!)");
    }
}