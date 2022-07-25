/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int DigitSum(int num=1)
{
    if (num/10!=0) 
    {
        return num%10+DigitSum(num/10);
    }
    else
    {
        return num;
    }
}

Console.Write("Введите число: ");
int num=Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DigitSum(num));





