namespace SquareLibraries;

public static class CircleArea
{
    public static double CalcCircleArea(double radius)
    {
        return 3.14 * radius * radius;
    }
}

public static class TriangleArea
{
    public static double CalcTriangleArea(double a, double b, double c)
    {
        double p = a + b + c;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}
