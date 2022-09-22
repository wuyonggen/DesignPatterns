namespace Prototype.Example;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(Circle source) : base(source)
    {
        Radius = source.Radius;
    }

    public Circle()
    {
    }

    public override Shape Clone()
    {
        return new Circle(this);
    }

    private bool Equals(Circle other)
    {
        return base.Equals(other) && Radius == other.Radius;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Circle)obj);
    }

    public override int GetHashCode()
    {
        return Radius;
    }
}