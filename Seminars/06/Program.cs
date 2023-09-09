/*
Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
*/

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] ints, int minValue, int maxValue)
{
    Random rnd = new Random();
    for (int i = 0; i < ints.GetLength(0); i++)
        for (int j = 0; j < ints.GetLength(1); j++)
            ints[i, j] = rnd.Next(minValue, maxValue + 1);  // Next(2, 5) -> [2, 5)
}

void Print2DArray(int[,] ints)
{
    for (int i = 0; i < ints.GetLength(0); i++)
    {
        for (int j = 0; j < ints.GetLength(1); j++)
            Console.Write($"{ints[i, j]}\t");
        Console.WriteLine();
    }     
}

int sumDiag(int[,] array)
{
    int min = array.GetLength(0);
    if (array.GetLength(1)<min) min = array.GetLength(1);
    int sum = 0;
    for (int i=0; i < min; i++) sum += array[i,i];
    return sum;
}

int rows = InputNum("Введите количество строк: ");
int cols = InputNum("Введите количество столбцов: ");

int min = InputNum("Введите минимальное значение диапазона: ");
int max = InputNum("Введите максимальное значение диапазона: ");

int[,] anyArray = Create2DArray(rows, cols);
Fill2DArray(anyArray, min, max);
Print2DArray(anyArray);

int number = sumDiag(anyArray);
Console.WriteLine(number);





void Walk(DirectoryInfo root)
{
    // Получаем все файлы в текущем каталоге
    FileInfo[] files = root.GetFiles("*.*");

    if (files != null)
    {
        //выводим имена файлов в консоль
        foreach (FileInfo file in files)
            Console.WriteLine(file.FullName);
 //получаем все подкаталоги
        DirectoryInfo[] subDirs = root.GetDirectories();
        //проходим по каждому подкаталогу
        foreach (DirectoryInfo dirInfo in subDirs)
            //рекурсия
            Walk(dirInfo);
    }
}
//задаем папку для обхода
string rootDir = @"c:\Users\tdv12\OneDrive\Документы\C_Sharp\Selection_Sort";
//вызываем рекурсивный метод
Walk(new DirectoryInfo(rootDir));
