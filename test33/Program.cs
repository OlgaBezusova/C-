Console.WriteLine($"Введите число :");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = new int[6];
 for (int i = 0; i < 6; i++)
    {
        array[i] = new Random().Next(0,101);
    }
Console.WriteLine("["+ string.Join("," , array) + "]");
  bool log = false;
for (int i = 0; i < 6; i++)
{
    if (n==array[i]) 
    {
        log=true;
        break;
    }

}
if (log)
{
    Console.WriteLine("Число присутствует в массиве");
}
else
{
    Console.WriteLine("Числа нет в массиве");
}






