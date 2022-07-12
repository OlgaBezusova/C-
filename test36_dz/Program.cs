/*Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

double[] arrayNumbers = new double[6];
Console.Write("[");
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
}
Console.Write("]");
double sumNumbers= 0;
for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (i%2>0)
    {
        sumNumbers=sumNumbers+arrayNumbers[i];
    }

}
Console.WriteLine($"сумма элементов {sumNumbers}");






