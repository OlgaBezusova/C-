/* Напишите программу, которая на вход 
принимает позиции элемента в двумерном массиве, и возвращает
значение этого элемента или же указание, что такого элемента нет.Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/


int[, ] CreateArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

    return array;
}

void CheckArray(int i, int j, int[, ] array)
{
    if (i < array.GetLength(0) && j < array.GetLength(1) && i >= 0 && j >= 0)
    Console.WriteLine(array[i, j]);
    else
    Console.WriteLine("Такого элеента нет.");
}

int[, ] array = new int[4, 4];
array = CreateArray(array);
Console.WriteLine("Введите координаты: ");
int i = Convert.ToInt32(Console.ReadLine());
int j = Convert.ToInt32(Console.ReadLine());
CheckArray(i, j, array);


