/* Задача 58: Задайте две матрицы.
 Напишите программу, которая будет находить произведение двух матриц.*/

int[,] CreateFirstArray(int m, int n)
{
    int[,] matrix1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i, j] = new Random().Next(1, 10);
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}
int[,] CreateSecondArray(int m, int n)
{
    int[,] matrix2 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix2[i, j] = new Random().Next(1, 10);
            Console.Write(matrix2[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix2;
}


void CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    Console.WriteLine();
    int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            result[i, j] = matrix1[i, j] * matrix2[i, j];
            Console.Write(result[i, j] + " \t");
        }
        Console.WriteLine();
    }
}


CheckMatrix(CreateFirstArray(4, 4), CreateSecondArray(4, 4));





