namespace Calculator;

public class Circle : IFigure
{
    public FigureType Type { get; set; }
    public double Radius;
    public Circle(double r)
    {
        Radius = r;
        Type = FigureType.Circle;
    }
}
