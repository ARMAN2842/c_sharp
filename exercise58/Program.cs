// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows1 = ReadInt("Введите количество строк 1 матрицы: ");
int columns1 = ReadInt("Введите количество столбцов 1 матрицы: ");
int rows2 = ReadInt("Введите количество строк 2 матрицы: ");
int columns2 = ReadInt("Введите количество столбцов 2 матрицы: ");

int[,] matrix1 = new int[rows1, columns1];
int[,] matrix2 = new int[rows2, columns2];

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Произвведение матриц c данными размерами невозможно");
    return;
}
int[,] matrixResult = new int [matrix1.GetLength(0), matrix2.GetLength(1)];

ReadIntMatrix(matrix1, "1");

ReadIntMatrix(matrix2, "2");

Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(matrix1);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(matrix2);

Console.WriteLine();


for (int i = 0; i < matrix1.GetLength(0); i++)

    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        for (int k = 0; k < matrix2.GetLength(0); k++)
        {
            matrixResult[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }


Console.WriteLine("Результат произведения заданных матриц:");
PrintArray(matrixResult);

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

void ReadIntMatrix(int[,] matrix, string name)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = ReadInt($"Введите элемент матрицы {name} для её заполнения ");
        }
    }
}