/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void fillRndArray(double[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
//        array[i] = rnd.NextDouble()*100;
        array[i] = Math.Round(rnd.NextDouble() + rnd.Next(0,100),2);
}

// double MaxMin(double[] array)
// {
//     double max = array[0];
//     double min = array[0];
//     foreach (var item in array)
//     {
//         if (item > max) max = item;
//         if (item < min) min = item;
//     }
//     return max - min;
// }

double[] diffMaxMin(double[] array)
{
    double[] diff = new double[3];
    diff[1] = array[0];
    diff[2] = array[0];
    foreach (var item in array)
    {
        if (item > diff[1]) diff[1] = item;
        if (item < diff[2]) diff[2] = item;
    }
    diff[0] = diff[1] - diff[2];
    return diff;
}

void printArray(double[] array)
{
    Console.Write("Сгенерированный массив: [");
    for(int i = 0; i < array.Length-1; i++)
        Console.Write($"{array[i]:F2}; ");
    Console.WriteLine($"{array[array.Length-1]:F2}]");
}

int arraySize = InputNum("Введите размерность массива: ");
double[] Array = new double[arraySize];
fillRndArray(Array);
printArray(Array);
//Console.WriteLine($"Разность между максимальным и минимальным элементами: {MaxMin(Array):F2}");
Console.WriteLine($"Разность между максимальным и минимальным элементами: {diffMaxMin(Array)[1]:F2} - {diffMaxMin(Array)[2]:F2} = {diffMaxMin(Array)[0]:F2}");

