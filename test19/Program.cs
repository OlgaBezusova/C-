/* Задача 21: Напишите программу, которая принимает
 на вход координаты двух точек и находит расстояние между ними в 2D пространстве. */

Console.WriteLine("введите координаты точки А: x= ");
 double Ax=Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("y= ");
 double Ay=Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("введите координаты точки B: x= ");
 double Bx=Convert.ToDouble(Console.ReadLine());
 Console.WriteLine("y= ");
 double By=Convert.ToDouble(Console.ReadLine());

 double distance=Math.Sqrt(Math.Pow((Ax-Bx),2)+Math.Pow((Ay-By),2));
 Console.WriteLine(distance);
 

 

