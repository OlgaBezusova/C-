/* напишите программу, которая выводит случайное число из отрезка  [10,99] и показывает наибщльщую цифру числа
78 - > 8
12 - > 2
85 - > 8
*/

int n1, n2, n;
n= new Random().Next(10,99);
Console.WriteLine(n);
n1=n/10;
n2=n%10;
if (n1>n2)
{
    Console.WriteLine(n1);
}
else 
{
    Console.WriteLine(n2);
}




