/*Задача 18: Напишите программу, которая по заданному номеру
 четверти, показывает диапазон возможных координат
  точек в этой четверти (x и y)*/

int quarter;
Console.WriteLine("введите номер четверти: ");
quarter=Convert.ToInt32(Console.ReadLine());
if (quarter==1) 
{
  Console.WriteLine("x = 0,+~ ");
  Console.WriteLine("y = 0,+~ ");
}
if (quarter==2)
{
  Console.WriteLine("x = 0,+~ ");
  Console.WriteLine("y = 0,-~ ");
}
if (quarter==3)
{
  Console.WriteLine("x = 0,-~ ");
  Console.WriteLine("y = 0,-~ ");
}
if (quarter==4)
{
  Console.WriteLine("x = 0,-~ ");
  Console.WriteLine("y = 0,+~ ");
}
    

