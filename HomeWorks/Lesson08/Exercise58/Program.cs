/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
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

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Нельзя умножить данные матрицы. Количество столбцов первой матрицы не совпадает с количеством строк второй матрицы.");
        Environment.Exit(1);
    }
    else
    {
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultMatrix[i, j] = sum;
            }
        }
    }
    return resultMatrix;
}

int[] params1 = InputNums("Введите размерность и границы значений 1-й матрицы (через пробел): ");
int[] params2 = InputNums("Введите размерность и границы значений 2-й матрицы (через пробел): ");

int[,] matrix1 = CreateRandomMatrix(params1[0], params1[1], params1[2], params1[3]);
int[,] matrix2 = CreateRandomMatrix(params2[0], params2[1], params2[2], params2[3]);

Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine("Матрица 2");
PrintArray(matrix2);

int[,] matrix3 = MultiMatrix(matrix1, matrix2);
Console.WriteLine("Результирующая матрица");
PrintArray(matrix3);
