/*Задайте массив заполненный случайными положительными
 трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/


int [] arrayNumbers = new int[6];
Console.Write("[");
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(100, 1000);
    Console.Write(arrayNumbers[i] + " ");
}
Console.Write("]");
int CountHonest(int[] arrayNumbers)
{
    int countHonest = 0;
    for (int i = 0; i<arrayNumbers.Length; i++ )
    {
        if (arrayNumbers[i] % 2 == 0)
        {
            countHonest++;}
    }
    return countHonest;
}
int countHonest=CountHonest(arrayNumbers);
Console.WriteLine($"количество четных элементов {countHonest}");
