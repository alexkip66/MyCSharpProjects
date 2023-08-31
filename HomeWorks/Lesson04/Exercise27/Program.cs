/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.-
452 -> 11
82 -> 10
9012 -> 12
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int SumOfDigit(int num)
{
    int res = 0;
    while (num != 0)
    {
        res = res + num % 10;
        num /= 10;
    }
    return res;
}

int number = InputNum("Введите число: ");
Console.WriteLine($"Сумма цифр числа равна {SumOfDigit(number)}");