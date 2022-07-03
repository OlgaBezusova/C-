/* Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int n3 = -1;

while (number > 99)
{
    n3 = number % 10;
    number = number / 10;
}

if (n3 != -1)
{
    Console.WriteLine(n3);
}
else
{
    Console.WriteLine("третьей цифры нет");
}

