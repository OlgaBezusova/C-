/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 456 -> 5
782 -> 8
918 -> 1*/


int n, n2;
n= Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n);
n2 = ((n / 10) % 10);
Console.WriteLine(n2);




