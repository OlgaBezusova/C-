/*Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

double[, ] CreateMatr(int n, int m )
{
    double[, ] matrix = new double[n ,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] =new Random().NextDouble()*10;
            }
        }
    return matrix;
}


void PrintMatr(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Math.Round(matrix[i, j],2)+ " ");
            }   
        Console.WriteLine();
        
    }
}
Console.Write($"Введи число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"Введи число m: ");
int m = Convert.ToInt32(Console.ReadLine());
PrintMatr(CreateMatr(n, m));

