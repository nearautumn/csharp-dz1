﻿Console.WriteLine("Является ли число четным?"); 
Console.Write("Введите целое число: "); 
int number = int.Parse(Console.ReadLine() ?? "");

if(number % 2 == 0) 
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}