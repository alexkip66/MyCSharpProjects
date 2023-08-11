/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int num = N;
int dig_count = 0;
while (num != 0)
{
    num /= 10;
    dig_count++;
}

if (dig_count >= 3)
{
    int divisor = (int)Math.Pow(10, dig_count - 3);
    int thirdDigit = (N / divisor) % 10;
    Console.WriteLine($"Третья цифра числа {N} - {thirdDigit}");
}
else 
{
    Console.WriteLine($"Третьей цифры в числе {N} нет.");
}
*/

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

if (N < 100)
{
    Console.WriteLine($"Третьей цифры в числе {N} нет.");
}
else
{
    int num = N;

    while (num > 1000)
    {
        num /= 10;
    }
    num %= 10;
    Console.WriteLine($"Третья цифра числа {N} - {num}");
}
