/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int CalcSumRec(int m, int n)
{
    if (m > n) return 0;
    return m + CalcSumRec(m + 1, n);
}

int numM = InputNum("Введите значение M: ");
int numN = InputNum("Введите значение N: ");
int sum = CalcSumRec(numM, numN);
Console.WriteLine($"Сумма натуральных чисел от {numM} до {numN}: {sum}");