/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4 */

Console.Write("Введите число N  ");
int N=Convert.ToInt32(Console.ReadLine());
int i;
double square;

for (i=1; i<N; i++)
{
    square=Math.Pow(i,2);
    Console.WriteLine($"{square}, ");
} 
square=Math.Pow(i,2);
Console.WriteLine(square);
