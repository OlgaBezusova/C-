﻿/*  Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */ 


// 52
int[, ] CreateMatrix(int[, ] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i , j] = new Random().Next(1, 100);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
return matrix;
}


void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double avg = 0;
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            avg = avg + matrix[j, i];
        }
        Console.WriteLine(i + 1 + " столбец: " + avg/matrix.GetLength(0));
    }
}

int[, ] matrix = new int[5, 4];
matrix = CreateMatrix(matrix);
AvgMatrix(matrix);