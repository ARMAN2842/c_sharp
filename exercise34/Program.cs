// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(100, 999);
}

int CountNum(int[] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
    if (array[i] % 2 ==0)
      count++;
  return count;
}

void PrintArray(int[] array)
{
  foreach (var el in array)
    Console.Write($"{el} ");
  Console.WriteLine();
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
Console.WriteLine($"-> {CountNum(array)}");
