
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
                 Console.Write(array[i, j] + "\t ");
            }
            Console.WriteLine();
        }

    return array;
}
void NewArray(int[, ] array)
{
    Console.WriteLine(); 
    int x;
    if (array.GetLength(0) == array.GetLength(1))
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i < j)
                {  
                    x = array[i, j];
                    array[i, j] = array[j, i];
                    array[j, i] = x;
                }  
            }
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    else
        Console.WriteLine("Такое невозможно!");

}

int[, ] array = new int[4, 4];
array = CreateArray(array);
NewArray(array);
