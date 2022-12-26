/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Задайте значение числа M: ");
int m = Convert.ToInt32(Console.ReadLine()); //Конвертируем в число

Console.Write("Задайте значение числа N: ");
int n = Convert.ToInt32(Console.ReadLine()); //Конвертируем в число

SumMToN(m, n);

void SumMToN(int m, int n) // Функциия "сумма чисел от M до N"
{
    Console.Write("Сумма чисел от M до N равна: " + SumMN(m - 1, n));
}

int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}
