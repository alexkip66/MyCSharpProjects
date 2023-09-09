/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int[] InputNumbers(string message)
{
    Console.Write(message);
    int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
    return numbers;
}

int[,] CreateSpyralArray(int m, int n)
{
    int[,] spiralArray = new int[m, n];

    int left = 0, right = n - 1, top = 0, bottom = m - 1;
    int current = 1;

    while (current <= m * n)
    {
        for (int i = left; i <= right; i++)
            spiralArray[top, i] = current++;
        top++;

        for (int i = top; i <= bottom; i++)
            spiralArray[i, right] = current++;
        right--;

        for (int i = right; i >= left; i--)
            spiralArray[bottom, i] = current++;
        bottom--;

        for (int i = bottom; i >= top; i--)
            spiralArray[i, left] = current++;
        left++;
    }
    return spiralArray;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]:D2} ");
        Console.WriteLine();
    }
}

int[] dimension = InputNumbers("Введите размерность массива (через пробел): ");
int[,] array = CreateSpyralArray(dimension[0], dimension[1]);
PrintArray(array);