Console.WriteLine("Введите значение k1:");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b1:");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
var b2 = Convert.ToDouble(Console.ReadLine());
void Cross()
{
    if (k1 == k2 && b1 == b2)
    {
        Console.WriteLine("Прямые совпадают!");
    }
    else if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны и не пересекаются!");
    }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых ({x};{y})");
    }
}
Cross();