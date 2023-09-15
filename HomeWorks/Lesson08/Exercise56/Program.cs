/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[] InputNums(string message)
{
    Console.Write(message);
    int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
    return arr;
}

int[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = rnd.Next(minLimitRandom, maxLimitRandom+1);
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]}\t");
        Console.WriteLine();
    }
}

int MinRowSumIndex(int[,] array)
{
    int minSum = int.MaxValue;
    int minRowIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int currentSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            currentSum += array[i, j];
        }

        if (currentSum < minSum)
        {
            minSum = currentSum;
            minRowIndex = i;
        }
    }
    return minRowIndex;
}

int[] dimension = InputNums("Введите размерность массива (через пробел): ");
int[] rndLimits = InputNums("Введите границы значений массива (через пробел): ");
int[,] matrix = CreateRandomMatrix(dimension[0], dimension[1], rndLimits[0], rndLimits[1]);

Console.WriteLine("Исходный массив:");
PrintArray(matrix);

Console.WriteLine($"Строка с наименьшей сцммой элементов: {MinRowSumIndex(matrix)+1}");