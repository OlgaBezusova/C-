﻿/*  программу, которая принимает на вход координаты точки (X и Y),
 причём X ≠ 0 и Y ≠ 0 и выдаёт
 номер четверти плоскости, в которой находится эта точка.*/

 int GetNumberOfQuarter(double X, double Y)
 {
    int result=0;
    if ( X>0 && Y>0 )
        {
            result = 1;
        }
    else if (X<0 && Y>0) 
        {
            result = 2;
        }  
    else if (X<0 && Y<0) 
        {
            result = 3;
        }  
    else if (X>0 && Y<0) 
        {
            result = 4;
        } 

    return result;
 }

Console.WriteLine("введите десятичную координату X ");
double userX=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("введите десятичную координату Y ");
double userY=Convert.ToDouble(Console.ReadLine());

int quarter=GetNumberOfQuarter(userX, userY);
Console.WriteLine($"Точка с координатами [{userX}:{userY}] лежит в {quarter} четверти.");








