﻿/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

double[] arrayNumbers = new double[5];
Console.Write("[");
for (int i = 0; i < arrayNumbers.Length; i++ )
{
    arrayNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayNumbers[i] + " ");
}
Console.Write("]");
double maxNumber = arrayNumbers[0];

double minNumber = arrayNumbers[0];
for (int i = 1; i < arrayNumbers.Length; i++)
{
    if (maxNumber < arrayNumbers[i])
    {
        maxNumber = arrayNumbers[i];
    }
    if (minNumber > arrayNumbers[i])
    {
        minNumber = arrayNumbers[i];
    }
}
double decision = maxNumber - minNumber;
Console.WriteLine($"разница между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");


/*Console.WriteLine("Введите размер массива ");
int a=Convert.ToInt32(Console.ReadLine());
double[] array= new double [a];
for(int i =0; i<array.Length; i++){
array[i]=new Random().NextDouble()*100;}*/