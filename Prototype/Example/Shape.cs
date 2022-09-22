namespace Prototype.Example;

public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }
    public string Color { get; set; }

    public Shape()
    {
    }

    public Shape(Shape source)
    {
        X = source.X;
        Y = source.Y;
        Color = source.Color;
    }

    private bool Equals(Shape other)
    {
        return X == other.X && Y == other.Y && Color == other.Color;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != GetType()) return false;
        return Equals((Shape)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Color);
    }

    public abstract Shape Clone();
}