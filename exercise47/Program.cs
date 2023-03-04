// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] twoDimArray = new double[m, n];
Random rnd = new Random();
void PrintArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void FillArray(double[,] array)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < m; j++)
        array[i, j] = Convert.ToDouble(rnd.Next(-10, 10));
    }
}

FillArray(twoDimArray);
Console.WriteLine();
PrintArray(twoDimArray);