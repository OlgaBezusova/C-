/* 53 */


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
    for (int i = 0; i < array.GetLength(1); i++)
        {
            x = array[0, i];
            array[0, i] = array[array.GetLength(0) - 1, i];
            array[array.GetLength(0) - 1, i] = x;
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

int[, ] array = new int[4, 4];
array = CreateArray(array);
NewArray(array);



