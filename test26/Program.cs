/* программа, принимает на вход число и 
выдает колличество цифр в числе.*/

int n=Convert.ToInt32(Console.ReadLine());
int count=0;
while (n > 0)
{
    count=count+1;
    n=n/10;
}
Console.WriteLine(count);
