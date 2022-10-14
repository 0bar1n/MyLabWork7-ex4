using System;

namespace MyLabWork7_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y; //переменные вещественного типа
            x = 3.4; //задние переменной из условия
            y = Math.Log(Math.Pow(Math.Abs(1-Math.Sqrt(Math.Sin(x))),2)) - (2 / Math.Exp(x)); //задание переменной по формуле
            Console.WriteLine($"при х={x}, y={y}"); //вывод на экран
        }
    }
}