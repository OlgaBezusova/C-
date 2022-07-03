/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите число, соответствующее дню недели: ");
int digit = Convert.ToInt32(Console.ReadLine());

if (digit == 6 || digit == 7)
{
    Console.WriteLine("Выходной");
}
else if (digit < 6 && digit >0)
{
    Console.WriteLine("Будни");
}
else
{
    Console.WriteLine("Введено число не соответствующее дню недели");
}
