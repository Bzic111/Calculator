namespace Calculator;

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