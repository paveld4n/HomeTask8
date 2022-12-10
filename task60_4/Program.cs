// Task 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine($"Введите размер массива X x Y x Z: ");
Console.WriteLine("Введите первый размер - x");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите вторрой размер - y");
bool isParsedY = int.TryParse(Console.ReadLine(), out int y);

Console.WriteLine("ВВведите третий размер - z");
bool isParsedZ = int.TryParse(Console.ReadLine(), out int z);

if(!isParsedX || !isParsedY || !isParsedZ)
{
    Console.WriteLine("Ошибочный ввод! Не цифра! ПереВВедите!");
    return;
}
int countNumsMax = 90;

if (x * y * z > countNumsMax)
{
    Console.Write("Ошибка!! Массив слишком большой! Уменьшите размерность");
    return;
}
Console.Clear();

int[,,] resultNums = Create3DMassive(x, y, z);

PrintArray(resultNums);


void PrintArray(int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
      for (int j = 0; j < array3D.GetLength(1); j++)
      {
          for (int k = 0; k < array3D.GetLength(2); k++)
          {
            
              Console.WriteLine($"{array3D[i, j, k]}  [{i},{j},{k}]");
          }
          Console.WriteLine();
      }
      Console.WriteLine();
  }
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    Random rand = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (array[i, j, k] == 0)
                {
                    int number = rand.Next(10, 99);

                    if (CheckRepetition(array, number) == false)
                    {
                        array[i, j, k] = number;
                    }
                }

            }
        }
    }
    return array;
}

bool CheckRepetition(int[,,] array, int number)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int h = 0; h < array.GetLength(2); h++)
            {
                if (array[i, j, h] == number) return true;
            }
        }
    }

    return false;
}

