/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CalculatePower(int baseNumber, int exponent)
{
    int result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result *= baseNumber;
    }

    return result;
}

int a = InputNum("Введите число A: ");
int b = InputNum("Введите степень B: ");
Console.WriteLine($"{a} в степени {b} равно {CalculatePower(a, b)}");
