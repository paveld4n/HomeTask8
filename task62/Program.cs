/*Напишите метод, который заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.WriteLine("Задайте первую цифру начала мартицы");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

if(!isParsedX)
{
    Console.WriteLine("Ошибочный ввод! ПереВВедите!"); // либо не цифра, либо не соблюдены требоавания к перемножению матриц
    return;
}

int n = 4;
int[,] array = new int[n, n];
Console.WriteLine();
int num = x;
for (int i = 0; i < 3; i++)
{
    array[0, i] = num++;
}
for (int i = 0; i < 3; i++)
{
    array[i, 3] = num++;
}
for (int i = 3; i > 0; i--)
{
    array[3, i] = num++;
}
for (int i = 3; i > 1; i--)
{
    array[i, 0] = num++;
}
for (int i = 0; i < 2; i++)
{
    array[1, i] = num++;
}
for (int i = 1; i < 2; i++)
{
    array[i, 2] = num++;
}
for (int i = 2; i > 0; i--)
{
    array[2, i] = num++;
}

PrintArray(array);
Console.WriteLine();

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < 10)
            {
                Console.Write($"0{array[i, j]} ");
            }
            else
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

