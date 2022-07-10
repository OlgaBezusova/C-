/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


void FillArrayNumber(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("введите число ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    
}
int[] array= new int [8];
 FillArrayNumber(array);
 PrintArray(array);



