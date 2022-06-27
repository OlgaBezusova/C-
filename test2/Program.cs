/*  Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
 *   a = 5; b = 7 -> max = 7
 *   a = 2 b = 10 -> max = 10
 *   a = -9 b = -3 -> max = -3 
 */

Console.WriteLine($"Введите первое число:");
int num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе число:");
int num_2 = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if(num_1 > num_2){ max = num_1; min = num_2; }
else{ max = num_2; min = num_1; }

Console.WriteLine($"Максимальное число = {max}\nМинимальное число = {min}");
