/*Напишите программу, которая принимает на вход пятизначное 
число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int num1, num2, num4, num5;
num1 = number / 10000;
num2 = (number % 10000) / 1000;
num4 = (number % 100) / 10;
num5 = number % 10;
if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("да, палиндром");
}
else
{
    Console.WriteLine("нет");  
}



