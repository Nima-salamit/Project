// Define an object of Type Person
public class Rectangle : Polygon
{
    public Rectangle(int length, int width)
    {
        Length = length;
        Width = width;
    }
    public int Length { get; set; }
    public override int Area()
    {
        return Length * Length;
    }
}
