/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
            array[i, j] = rnd.Next(minLimitRandom, maxLimitRandom);
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

void SortRows(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int i = 0; i < matrix.GetLength(1) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - i - 1; j++)
            {
                if (matrix[row, j] > matrix[row, j + 1])
                {
                    int temp = matrix[row, j];
                    matrix[row, j] = matrix[row, j + 1];
                    matrix[row, j + 1] = temp;
                }
            }
        }
    }

}

int[] dimension = InputNums("Введите размерность массива (через пробел): ");
int[] rndLimits = InputNums("Введите границы значений массива (через пробел): ");
int[,] matrix = CreateRandomMatrix(dimension[0], dimension[1], rndLimits[0], rndLimits[1]);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);
SortRows(matrix);
Console.WriteLine("Отсортированные строки:");
PrintArray(matrix);
