// 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

string DiffArray(int [] array)
{
    string result = "";
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    for (int i = 0; i < array.Length; i++)
        if (min > array[i])
            min = array[i];
    result = $"[{string.Join(", ", array)}] -> {max - min}";
    return result;
}


int[] array = new int[5];
FillArray(array);
Console.WriteLine(DiffArray(array));