/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double InputDouble(string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine()!);
}

double[] LineCross(double k1, double b1, double k2, double b2)
{
    double[] Cross = new double[2];
    Cross[0] = (b2 - b1) / (k1 - k2);
    Cross[1] = k1 * Cross[0] + b1;
    return Cross;
}

double k1 = InputDouble("Введите k1 (коэффициент наклона первой прямой): ");
double b1 = InputDouble("Введите b1 (свободный член первой прямой): ");
double k2 = InputDouble("Введите k2 (коэффициент наклона второй прямой): ");
double b2 = InputDouble("Введите b2 (свободный член второй прямой): ");

double[] xyCross = new double[2];
xyCross = LineCross(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения прямых: ({xyCross[0]}, {xyCross[1]})");

