/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] InputArray(int arraySize)
{
    int[] array = new int[arraySize];

    Console.WriteLine($"Введите {arraySize} элементов массива:");

    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Элемент {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");

}

int size = InputNum("Введите размерность массива: ");
int[] Array = InputArray(size);
PrintArray(Array);



