//Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Задайте количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int numbers(int N, int min, int max)
  {
  int[] Numbers = new int[N];
  int sum = 0;

    for (int i = 0; i <Numbers.Length; i++ )
    {
      Numbers[i] = new Random().Next(min, max);

      Console.Write(Numbers[i] + " ");

      if (i % 2 != 1)
      {
        sum = sum + Numbers[i];
      }
    }
  return sum;
  }

int Numbers =  numbers(N, 1, 10);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {Numbers}");