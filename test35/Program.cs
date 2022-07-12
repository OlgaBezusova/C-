/* задача 35:Задайте одномерны массив мз 123 чисел. 
Найдите количество элеентов массива, значения которых лежат в промежутке (10,99)*/



int[] array = new int[123];

 for (int i = 0; i < 6; i++)
    {
        array[i] = new Random().Next(-10,101);
    }

int count=0;
for (int i = 0; i < 6; i++)
{
    if (array[i]>=10 && array[i]<=99) 
    {
        count=count+1;
    }
}

Console.WriteLine(count);


