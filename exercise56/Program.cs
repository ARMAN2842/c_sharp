// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");

if (rows != columns)
{
    Console.WriteLine("Массив не прямоугольный");
    return;
}
int[,] numbers = new int[rows, columns];

FillArray(numbers);

Console.WriteLine("Изначальный массив:");
PrintArray(numbers);

Console.WriteLine();

int indexMinRow = 0;

int sumMinRow = SumNumbersInRow(numbers, 0);

for (int i = 0; i < numbers.GetLength(0); ++i)
{
    int sumMinRowTemp = SumNumbersInRow(numbers, i);
    
    if (sumMinRowTemp <  sumMinRow)
    {
           indexMinRow = i;
    }
}
Console.WriteLine($"Строка {indexMinRow + 1} имеет наименьшую сумму элементов");


int SumNumbersInRow(int[,] sumArray, int row)
{
    int sum = 0;
    for (int i = 0; i < sumArray.GetLength(1); i++)
    {
        sum += sumArray[row, i];
    }
    return sum;
}

    void FillArray(int[,] fillArray)
    {
        for (int i = 0; i < fillArray.GetLength(0); i++)
        {
            for (int j = 0; j < fillArray.GetLength(1); j++)
            {
                fillArray[i, j] = new Random().Next(1, 10);
            }
        }
    }

    void PrintArray(int[,] writeArray)
    {
        for (int i = 0; i < writeArray.GetLength(0); i++)
        {
            for (int j = 0; j < writeArray.GetLength(1); j++)
            {
                Console.Write(writeArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
