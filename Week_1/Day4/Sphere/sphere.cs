using System;
using System.Drawing;

public class Sphere : IComparable<Sphere>
{
    private double radius;

    public double Radius
    {
        get => radius;
        set
        {
            if (value < 0)
                throw new ArgumentException("Radius cannot be negative.");
            radius = value;
        }
    }

    public double Diameter
    {
        get => radius * 2;
        set => radius = value / 2;
    }

    public Sphere(double radius)
    {
        Radius = radius;
    }

    public static Sphere FromDiameter(double diameter)
    {
        return new Sphere(diameter / 2);
    }

    public double Volume => (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

    public double SurfaceArea => 4 * Math.PI * Math.Pow(radius, 2);

    public Sphere Scale(double factor)
    {
        if (factor <= 0)
            throw new ArgumentException("Scale factor must be positive.");

        return new Sphere(this.radius * factor);
    }

    public override string ToString()
    {
        return $"Sphere (Radius: {Radius:F2}, Diameter: {Diameter:F2}, Volume: {Volume:F2}, Surface Area: {SurfaceArea:F2})";
    }

   
    public static Sphere operator +(Sphere a, Sphere b)
    {
        return new Sphere(a.radius + b.radius);
    }

   
    public static bool operator >(Sphere a, Sphere b)
    {
        return a.Volume > b.Volume;
    }

    public static bool operator <(Sphere a, Sphere b)
    {
        return a.Volume < b.Volume;
    }

    // == and !=
    public static bool operator ==(Sphere a, Sphere b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;

        return a.radius == b.radius;
    }

    public static bool operator !=(Sphere a, Sphere b)
    {
        return !(a == b);
    }

    public int CompareTo(Sphere other)
    {
        return this.radius.CompareTo(other.radius);
    }

    public override bool Equals(object obj)
    {
        return obj is Sphere s && s.radius == this.radius;
    }

    public override int GetHashCode()
    {
        return radius.GetHashCode();
    }


    public void Draw(Graphics g, int x, int y, float scale = 1f,Color? fillColor = null, Color? borderColor = null)
    {
        float diameterPixels = (float)(this.Diameter * scale);

        Color fill = fillColor ?? Color.LightBlue;
        Color border = borderColor ?? Color.DarkBlue;

        using (SolidBrush brush = new SolidBrush(fill))
        using (Pen pen = new Pen(border, 3))
        {
            g.FillEllipse(brush, x, y, diameterPixels, diameterPixels);
            g.DrawEllipse(pen, x, y, diameterPixels, diameterPixels);
        }
    }
}
