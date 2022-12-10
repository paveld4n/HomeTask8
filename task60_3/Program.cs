// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите метод, который будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine($"Введите размер массива X x Y x Z: ");
Console.WriteLine("Введите первый размер - x");
bool isParsedX = int.TryParse(Console.ReadLine(), out int x);

Console.WriteLine("Введите второй размер - y");
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

int[] arrayselect = CreateEndMix(countNumsMax);
int[,,] resultArray = Array3DMassive(x, y, z, arrayselect);

PrintArray(resultArray);


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

int[] CreateEndMix(int NumsMax)
{
    int[] values = new int[NumsMax];
    int num = 10;
    for (int i = 0; i < values.Length; i++)
        values[i] = num++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }
    return values;
}

int[,,] Array3DMassive(int size1, int size2, int size3, int[] values)
{
    int[,,] array = new int[size1, size2, size3];
    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
            array[i, j, k] = values[valueIndex++];
            }
        }       
    }
    return array;
}

    
