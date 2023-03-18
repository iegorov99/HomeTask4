// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Sum(int A)
{
    int res = 0;
    while (A > 0)
    {
        res += A % 10;
        A /= 10;
    }
    return res;
}

Console.Write("Введите число:");
decimal num = Convert.ToDecimal(Console.ReadLine());
decimal numA = num;
while (numA % 1 > 0)
{
    numA *= 10;
}
int A = Convert.ToInt32(numA);
Console.WriteLine($"Сумма цифр числа {num} равна {Sum(A)}");
