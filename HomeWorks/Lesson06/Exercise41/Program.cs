/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

string InputStr(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

int CountPositive()
{
    Console.WriteLine("Введите числа (для завершения введите пустую строку):");

    int countPositive = 0;
    while (true)
    {
        string input = InputStr("Введите число: ");

        if (double.TryParse(input, out double number) && number > 0)
            countPositive++;

        if (string.IsNullOrEmpty(input))
            break; // Если введена пустая строка, завершаем ввод чисел
    }
    return countPositive;
}
Console.WriteLine($"Количество чисел больше 0: {CountPositive()}");