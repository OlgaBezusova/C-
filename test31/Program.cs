/* Задайте массив из 12 элементов, заполненный случайными 
 числами из промежутка [-9, 9]. Найдите сумму отрицательных 
 и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
положительных чисел равна 29, сумма отрицательных равна -20.

int[] array= new int[12];
int[] sum =new int [2];
void FillArray(int[] collection, int [] sum);
{
    for (int i = 0; i < collection.length; i++)
    {
        array[i]=new Random().Next(-9,10);
        if (array[i]>0)
        {
            sum[0]=sum[0]+array[i];
        }
        else
            sum[1]=sum[1]+array[i];
    }
}
FillArray(array, sum);
Console.WriteLine("Сумма положительных чисел ={0} и отрицательных ={1}",sum[0], sum[1] );*/


int[] array = new int[12];
int[] sum = new int[2];
void FillArray(int[] collection, int[] sum)
{
    for (int i = 0; i < collection.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
        if (array[i] > 0)
            sum[0] = sum[0] + array[i];
        else
            sum[1] = sum[1] + array[i];
    }
}
FillArray(array, sum);
Console.WriteLine("Суммы положительных цифр = {0} и отр. = {1}", sum[0], sum[1]);






