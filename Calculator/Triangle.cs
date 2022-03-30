namespace Calculator;

public class Triangle : IFigure
{
    public FigureType Type { get; set; }
    
    public TriangleType? TType { get; set; }
    public List<double> LenghtsOfEdges { get; set; }
    public Triangle(double[] lenghts)
    {
        if (lenghts.Length != 3)
        {
            throw new ArgumentException("количество длинн не совпадает с количеством сторон треугольника");
        }
        else
        {
            LenghtsOfEdges = lenghts.ToList();
            LenghtsOfEdges.Sort(); 
            var a = LenghtsOfEdges[0];
            var b = LenghtsOfEdges[1];
            var c = LenghtsOfEdges[2];
            if (a+b<c||a+c<b||c+b<a)
            {
                throw new ArgumentException("Сумма длинн двух сторон не может быть меньше длины третьей стороны");
            }
            Type = FigureType.Triangle;
            CheckTriangle();
        }
    }

    public void CheckTriangle()
    {
        var a = LenghtsOfEdges[0];
        var b = LenghtsOfEdges[1];
        var c = LenghtsOfEdges[2];

        if (a == b && b == c)
        {
            TType = TriangleType.Regular;
        }
        else if (a * a + b * b == c * c)
        {
            TType = TriangleType.Right;
        }
        else if (a == b || b == c)
        {
            TType = TriangleType.Isosceles;
        }
        else
        {
            TType = TriangleType.Arbitrary;
        }
    }    
}
