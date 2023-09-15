/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[] InputNumbers(string message)
{
    Console.Write(message);
    int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(' '), int.Parse);
    return numbers;
}

int[,,] CreateRandomArray3D(int l, int m, int n, int minLimitRandom, int maxLimitRandom)
{
    int[,,] array = new int[l, m, n];
    //    List<int> usedNumbers = new List<int>(l * m * n);
    List<int> usedNumbers = new List<int>(array.Length);
    Random random = new Random();
    for (int i = 0; i < l; i++)
        for (int j = 0; j < m; j++)
            for (int k = 0; k < n; k++)
            {
                int randomNumber;
                do randomNumber = random.Next(minLimitRandom, maxLimitRandom+1);
                while (usedNumbers.Contains(randomNumber));
                array[i, j, k] = randomNumber;
                usedNumbers.Add(randomNumber);
            }
    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
        Console.WriteLine($"----- {k + 1}-й слой -----");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            //    Console.Write($"{array[i, j, k]} ({i},{j},{k})\t");
            Console.Write($"{array[i, j, k]}\t");
            Console.WriteLine();
        }
    }
}

bool correctDim;
int[] dimension = new int[3];
do
{
    dimension = InputNumbers("Введите размерность массива (через пробел): ");
    int length = dimension[0] * dimension[1] * dimension[2];
    if (length > 90)
    {
        correctDim = false;
        Console.WriteLine($"Комбинация размерностей массива равна {length}, что превышает допустимую (90)");
    }
    else correctDim = true;
} while (correctDim == false);
int[,,] array3D = CreateRandomArray3D(dimension[0], dimension[1], dimension[2], 10, 99);
PrintArray3D(array3D);
