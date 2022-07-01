/* напишите программу, которая выводит случайное число из отрезка  [10,99] и показывает наибщльщую цифру числа
78 - > 8
12 - > 2
85 - > 8
*/

int GetRandomNumber(int minBorder, int maxBorder);
{
    int result = new Random().Next(minBorder, maxBorder+1 );
    return result;
}
int randomNumber = GetRandomNumber(10,99);
Console.WriteLine(randomNumber);

