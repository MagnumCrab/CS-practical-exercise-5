//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];
int sum = 0;
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(1, 10);
    Console.Write(array[i] + " ");
    
    if (i % 2 == 1)
      {
        sum += array[i];
      }
  }

  Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {sum}");