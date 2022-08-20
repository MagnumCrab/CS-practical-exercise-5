//Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

double[] Array = new double[10];
  for (int i = 0; i < Array.Length; i++ )
  {
    Array[i] = new Random().Next(1, 10);
    Console.Write(Array[i] + " ");
  }

double max = Array[0];
double min = Array[0];

  for (int i = 1; i < Array.Length; i++)
  {
    if (max < Array[i])
    {
      max = Array[i];
    }
        if (min > Array[i])
    {
      min = Array[i];
    }
  }
  double ans = max - min;

  Console.WriteLine($"\nРазница между между максимальным и минимальным элементами массива = {ans}");