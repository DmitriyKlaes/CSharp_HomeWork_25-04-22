/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int a = number / number + 1; a <= number; a = a + 2)
{
    Console.Write(a);
    if (a < number - 1)
    {
        Console.Write(", ");
    }
}