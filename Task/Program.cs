// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int DegreeA(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    return result;
}

double DegreeB(int A, int B)
{
    double result = Convert.ToDouble(A);
    B = Math.Abs(B);
    for (int i = 1; i < B; i++)
    {
        result = result * A;
    }
    result = 1 / result;
    return result;
}

try
{
    Console.Write("Введите первое натуральное число число: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе натуральное число число: ");
    int B = Convert.ToInt32(Console.ReadLine());
    if (A == 0)
        Console.WriteLine("Некорреектное первое число");
    else if (B == 0)
        Console.WriteLine($"Число {A} в степени {B} равно 1");
    else if (B > 0)
        Console.WriteLine($"Число {A} в степени {B} равно {DegreeA(A, B)}");
    else
        Console.WriteLine($"Число {A} в степени {B} равно {DegreeB(A, B)}");
}
catch
{
    Console.WriteLine("Одно или нексколько чисел введены некорреектно");
}