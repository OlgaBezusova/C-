/* Задача 39: Напишите программу, которая перевернёт
 одномерный массив (последний элемент будет на первом месте,
  а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/ 

int[] f(int[] array)
{
    for(int i = 0; i < array.Length/2; i++)
    {
        (array[i], array[array.Length-(i+1)]) = (array[array.Length-(i+1)], array[i]);
    }
    return array;
}
int n;
Console.WriteLine("Задайте длину массива : ");
n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
var random = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-99,99);
}
Console.WriteLine("Наш массив: ");
Console.WriteLine("[" + string.Join(",", array) + "]");
Console.WriteLine("[" + string.Join(",", f(array)) + "]");




