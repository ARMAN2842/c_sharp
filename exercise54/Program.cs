// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows  = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

Fill2DArray(numbers);
Console.WriteLine("Изначальный массив:");
Print2DArray(numbers);
Console.WriteLine();

for (int i = 0; i < numbers.GetLength(0); i++)
{
    SortRowMaxToMin(numbers, i);
}

Console.WriteLine("Отсортированный массив:");
Print2DArray(numbers);


void SortRowMaxToMin(int[,] sortArray, int row)
{
for (int i = 0; i < sortArray.GetLength(1); i++)
{
    for (int k =  0; k < sortArray.GetLength(1) -1; k++)
    {
       int temp;
       if (sortArray[row, k] < sortArray[row, k+1])
       {
            temp = sortArray[row, k];
            sortArray[row, k] = sortArray[row, k+1];
            sortArray[row, k+1] = temp;
       }
    }
    }
}

void Fill2DArray(int[,] fillArray)
{
    for (int i = 0; i < fillArray.GetLength(0); i++)
    {
        for (int j = 0; j < fillArray.GetLength(1); j++)
        {
            fillArray[i, j] = new Random().Next(1 , 10);
        }   
    }
}

void Print2DArray(int[,] writeArray)
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
