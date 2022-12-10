/*Задайте две матрицы. Напишите метод, который будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


/*Матрицу P можно умножить на матрицу K только в том случае, 
если число столбцов матрицы P равняется числу строк матрицы K. 
Матрицы, для которых данное условие не выполняется, умножать нельзя. */

Console.WriteLine("Введите размерность мартицы - n");
bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

if(!isParsedN || n < 0)
{
    Console.WriteLine("Ошибочный ввод! ПереВВедите!"); // либо не цифра, либо не соблюдены требоавания к перемножению матриц
    return;
}
Console.WriteLine("Первая матрица");
int[,] arrayOne = CreateRandom2DArray(n, n);
Print2DArray(arrayOne);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
int[,] arrayTwo = CreateRandom2DArray(n, n);
Print2DArray(arrayTwo);
Console.WriteLine();
Console.WriteLine("Результирующая матрица");
int[,] arrayRes = ProductOfArray(arrayOne, arrayTwo);
Print2DArray(arrayRes);

int[,] ProductOfArray(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] array = new int[n, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }
    }
    return array;
}


int [,] CreateRandom2DArray(int x, int y)
{
    int[,] array = new int[x, y];

    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 10);
        }
    }
    return array;
}

void Print2DArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}|");
        }
        Console.WriteLine();
    }
}