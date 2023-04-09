// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Write("Введите количество затребованных чисел: ");
int M = int.Parse(Console.ReadLine());

int[] array;
array = GenerateArray(M);
PrintArray(array);
Console.WriteLine();
Console.Write($" Положительных чисел: {SumNegativ(array)}");

int[] GenerateArray(int length)
{
   int[] array = new int[length];
   for (int i = 0; i < length; i++)
   {
      Console.Write($"Введите {i + 1}-й элемент: ");
      array[i] = int.Parse(Console.ReadLine());
   }
   return array;
}

void PrintArray(int[] array)
{
   Console.Write($"{string.Join(", ", array)}");
}

int SumNegativ(int[] array)
{
   int sum = 0;
   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
      {
         sum++;
      }
   }
   return sum;
}