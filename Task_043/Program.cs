// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например:
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.WriteLine();

double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2. ");
Console.WriteLine();
Console.WriteLine();
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
int a = arr[1];
int b = arr[3];
int c = arr[0];
int d = arr[2];

void PointIntersection(int a, int b, int c, int d)
{
    if (a == b)
    {
        Console.WriteLine("Прямые с такими параметрами параллельны.");
        Console.WriteLine();
    }
    else
    {
        pointX = (double)(d - c) / (a - b);
        pointY = (double)a * (d - c) / (a - b) + c;
        Console.WriteLine($"Координаты точки пересечения двух прямых: -> ({pointX:0.0}; {pointY:0.0})");
        Console.WriteLine();
    }
}
PointIntersection(a, b, c, d);
