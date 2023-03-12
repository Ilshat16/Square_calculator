using SquareLibraries;

class Programm
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Площадь какой фигуры хотите найти?: ");
        Console.WriteLine("1 - круг");
        Console.WriteLine("2 - треугольник");
        Console.Write("Введите цифру нужного варианта: ");
        int figure = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (figure == 1)
        {
            Console.Write("Введите радиус круга: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь круга равна {CircleArea.CalcCircleArea(radius)}");
        }

        if (figure == 2)
        {
            Console.Write("Введите первую сторону треугольника: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите вторую сторону треугольника: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Введите третью сторону треугольника: ");
            double c = double.Parse(Console.ReadLine());
            if ((a * a + b * b) == c * c
                || (b * b + c * c) == a * a
                || (c * c + a * a) == b * b) Console.WriteLine("Треугольник прямоугольный");
            Console.Write("Площадь треугольника равна: ");
            Console.WriteLine("{0:0.00}", TriangleArea.CalcTriangleArea(a, b, c));
        }
    }
}