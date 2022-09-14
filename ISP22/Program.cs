// See https://aka.ms/new-console-template for more information
using System.Drawing;

try
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Введите а:");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите b:");
    double b = double.Parse(Console.ReadLine());
    Console.Write("Введите c:");
    double c = double.Parse(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.Green;
    double res = ((b + Math.Sqrt(b * b + 4 * a * c)) / 2 * a) -
        Math.Pow(a, 3) * c + Math.Pow(b, -2);
    Console.WriteLine($"{res:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
