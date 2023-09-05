/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        array[i] = Rnd.Next(-99, 100);
}

int sumOdd(int[] array)
{
    int sum = 0;
   for(int i = 1; i < array.Length; i+=2)
        sum += array[i];
    return sum;
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
Console.WriteLine($"Сумма элементов на нечетных позициях: {sumOdd(Array)}");
