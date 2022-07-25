/* Задача 63: Задайте значение N. 
Напишите программу, которая выведет
 все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

void printNatural(int n, int count=1 )
{
    if (count==n)
    {
        Console.Write(n);
    }
    else 
    {
        Console.Write($"{count}, ");
        printNatural(n, count+1);
    }
}
Console.WriteLine("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"N = {n} -> ");
printNatural(n);



