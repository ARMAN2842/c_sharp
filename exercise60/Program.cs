// Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 х 2 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 25(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
        for (int i = 0; i < array.GetLength(1); i++)
            for (int j = 0; j < array.GetLength(2); j++)
                array[k, i, j] = new Random().Next(10, 99);
}

void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        Console.WriteLine("Пространство № "+ (k +1));

        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
                Console.Write($"{array[k, i, j],3} \t");
            Console.WriteLine();
        }

        Console.WriteLine("-----------------------");
    }
}

Console.WriteLine("Введите количество измерений");
int dimensions = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,,] array = new int[dimensions, rows, cols];
FillArray(array);
PrintArray(array);