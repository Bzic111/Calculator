namespace Calculator;

public static class CalculateSquare
{
    public static double GetSquare(IFigure figure)
    {
        switch (figure.Type)
        {
            case FigureType.Circle:
                Circle item = figure as Circle;
                return item.Radius * item.Radius * Math.PI;
            case FigureType.Triangle:
                Triangle tri = figure as Triangle;
                if (tri.TType is null)
                {
                    tri.CheckTriangle();
                }
                switch (tri.TType)
                {
                    case TriangleType.Isosceles: //goto case TriangleType.Arbitrary;
                        var b = tri.LenghtsOfEdges[0] == tri.LenghtsOfEdges[1] ? tri.LenghtsOfEdges[2] : tri.LenghtsOfEdges[0];
                        var p = b / 2;
                        var h = tri.LenghtsOfEdges[1] * tri.LenghtsOfEdges[1] - p * p;
                        return tri.LenghtsOfEdges[1] * Math.Sqrt(h) / 2;
                    case TriangleType.Right:
                        return tri.LenghtsOfEdges[0] * tri.LenghtsOfEdges[1] / 2;
                    case TriangleType.Arbitrary:
                        double p2 = 0;
                        for (int i = 0; i < 3; i++)
                        {
                            p2 += tri.LenghtsOfEdges[i];
                        }
                        p2 /= 2;
                        return Math.Sqrt(p2 * (p2 - tri.LenghtsOfEdges[0]) * (p2 - tri.LenghtsOfEdges[1]) * (p2 - tri.LenghtsOfEdges[2]));
                    case TriangleType.Regular:
                        return Math.Pow(tri.LenghtsOfEdges[0], 2) * (Math.Sqrt(3) / 4);
                    default:
                        return 0;
                }
            default:
                throw new Exception("Неверныый тип фигуры");
        }
    }
}
public static class Calculator
{
    public static double CalculateSquareOfCircle(double radius)
    {
        return radius * radius * Math.PI;
    }
    public static double CalculateSquareOfTriangle(double edgeA, double edgeB, double edgeC)
    {
        double p = (edgeA + edgeB + edgeC) / 2;
        return Math.Sqrt(p * (p - edgeA) * (p - edgeB) * (p - edgeC));
    }
    public static bool CheckTriangle(double edgeA, double edgeB, double edgeC)
    {
        return edgeA * edgeA + edgeB * edgeB == edgeC * edgeC;
    }
}