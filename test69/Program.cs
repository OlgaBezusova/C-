/* Задача 69: Напишите программу, 
которая на вход принимает два числа A и B, 
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

int Power(int a, int b)
{
return b==0? 1:Power(a, b-1)*a;

}

Console.WriteLine("Введите число А: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Power(a,b));



