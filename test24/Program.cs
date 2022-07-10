/*Console.WriteLine("Введите число A: ");
int sum = 0, n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
sum = sum + i;
}
Console.WriteLine(sum); */



int GetSumOfRange(int begnumber=1, int endnumber=1)
{
    var sumOfrange=0;
    for (int i = begnumber; i <= endnumber; i++) 
    {
        sumOfrange+=i;
    }
    return sumOfrange;

}
Console.WriteLine("Введите число А для получения суммы : ");

int endnumberForUser=Convert.ToInt32(Console.ReadLine());
int sumOfRange=GetSumOfRange(endnumber : endnumberForUser);

Console.WriteLine($"{endnumberForUser}->{sumOfRange}");
