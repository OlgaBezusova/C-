﻿/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int SummDigit(int m, int n)
{
    if (m == n)
    {
        return(m);
    }
    else
    {
        return  (m+SummDigit(m + 1, n));
    }
}

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($" Сумма чисел от {m} до {n} = {SummDigit(m, n)}");
