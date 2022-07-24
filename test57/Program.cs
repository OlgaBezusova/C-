/* составить частотный словарь элементов 
двумерного массива. Чатотный словарь содержит 
информацию о  том, сколько раз встречается элемент в масиве.*/

int[, ] CreateArray(int[, ] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                 Console.Write(array[i, j] + "\t ");
            }
            Console.WriteLine();
        }

    return array;
}
void AvgMatrix(int[, ] matrix)
{
    Console.WriteLine();
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    for (int i = 0; i < array.Length; i++)
    {
        int count = 1;
        for (int j = 0; j < array.Length; j++)
        {
            if(array[i] == array[j] && i != j)
            count++;
        }
        Console.WriteLine(array[i] + " встречается " + count + " раз");
}

}

int[, ] array = new int[3, 4];
array = CreateArray(array);
AvgMatrix(array);


