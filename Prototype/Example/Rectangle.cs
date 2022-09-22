namespace Prototype.Example;

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }


    public Rectangle()
    {
    }

    public Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }


    public override Shape Clone()
    {
        return new Rectangle(this);
    }

    private bool Equals(Rectangle other)
    {
        return base.Equals(other) && Width == other.Width && Height == other.Height;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Rectangle)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Width, Height);
    }
}