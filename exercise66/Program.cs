// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
//в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");
Console.WriteLine($"Сумма нат. элементов от {m} до {n} равна: " + sumIntNumbers(m, n));

int sumIntNumbers(int m, int n)
{
    if (m < n)
    {
        return m + sumIntNumbers(m + 1, n);
    }
    else if (m > n)
    {
        return m + sumIntNumbers(m - 1, n);
    }
    else
    {
        return n;
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}