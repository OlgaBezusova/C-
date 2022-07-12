
int[] array = new int[4];
 for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(-9,10);
    }
Console.WriteLine("["+ string.Join("," , array) + "]");
for (int i = 0; i < 4; i++)
    {
        array[i] = array[i] *(-1);   
    }

Console.WriteLine("["+ string.Join("," , array) + "]");

