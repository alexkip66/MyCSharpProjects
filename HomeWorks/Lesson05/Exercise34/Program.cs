/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void fillRndArray(int[] array)
{
    Random Rnd = new Random();
    for(int i = 0; i < array.Length; i++)
        array[i] = Rnd.Next(100, 1000);
}

int sumEven(int[] array)
{
    int count = 0;
    foreach (var item in array)
        if (item % 2 == 0)
            count ++;
    return count;
}

void printArray(int[] array)
{
    Console.Write("Сгенерированный массив: [");
    for(int i = 0; i < array.Length-1; i++)
        Console.Write($"{array[i]}, ");
    Console.WriteLine($"{array[array.Length-1]}]");
}

int arraySize = InputNum("Введите размерность массива: ");
int[] Array = new int[arraySize];
fillRndArray(Array);
printArray(Array);
Console.WriteLine($"Количество четных чисел: {sumEven(Array)}");
