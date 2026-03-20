namespace TestCIProject;

public static class GeometryService
{
    public static decimal SquareArea(decimal side) => side * side;
    
    public static decimal RectangleArea(decimal width, decimal height) => width * height;
    
    public static decimal TriangleArea(decimal baseSide, decimal height) => (baseSide * height) / 2;
}