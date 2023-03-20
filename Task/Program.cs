// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void FillArray(int[] array, int min, int max)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void PrintArray(int[] array)
{
    foreach (int i in array)
    {
        Console.Write($"{i} ");
    }
}

Console.Write("Введеите минимальное случайное число: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введеите максимальное случайное число: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[8];
FillArray(arr, min, max);
PrintArray(arr);