﻿/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Четное");
}
else 
{
    Console.WriteLine("Нечетное");
}

/*
switch (number % 2)
{
    case 0:
        Console.WriteLine("Четное");
        break;
    default:
        Console.WriteLine("Нечетное");
        break;
}
*/