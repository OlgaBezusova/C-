/*
 * Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 * 5 -> 2, 4
 * 8 -> 2, 4, 6, 8
 */

Console.WriteLine($"Введите N");
int num = Convert.ToInt32(Console.ReadLine());
int count = 1;

if( num > 0)
{
    while(count <= num)
    {
        if(count % 2 == 0){ Console.WriteLine($"Найдено четное число в диапазоне от 1 до {num}: {count}"); }
        count++;
    }
}
else
{
    Console.WriteLine($"Введите число больше 0!");
}
