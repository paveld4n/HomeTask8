// Задайте двумерный массив. Напишите метод, который будет находить строку с наименьшей суммой элементов.

Console.WriteLine("Введите количество строк задаваемого массива - m");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);

Console.WriteLine("Введите количество столбцов задаваемого массива - n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedM || !isParsedN)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}

int[,] array = CreateRandom2DArray(m, n);
Console.WriteLine("Сгенерированный исходный массив:");
Print2DArray(array);
Console.WriteLine();

int minsumline = MinSumOfElementsColumn(array);
Console.WriteLine($"Номер строки с наименьшей суммой: {minsumline} Строки считать с 1.");
Console.WriteLine();

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 9);
        }
    }
    return array;
}

void Print2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int MinSumOfElementsColumn (int [,] array)
{
    int indexLine = 0;
    int minsum = Int32.MaxValue;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
            // Console.WriteLine(sum);
        }
        if (minsum > sum)
        {
            minsum = sum;
            indexLine = i + 1;
        }
        // Console.WriteLine(sum);
        // Console.WriteLine(minsum);
        // Console.WriteLine(indexLine);
    }
    return indexLine;
}