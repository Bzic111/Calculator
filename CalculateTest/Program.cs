using Calculator;

double[] triangleEdges = { 15, 16, 17 };

List<IFigure> fgrs = new List<IFigure>();
fgrs.Add(new Circle(23));
fgrs.Add(new Triangle(triangleEdges));
foreach (var item in fgrs)
{
    Console.WriteLine(item.GetSquare());
}