﻿// 2.Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. Если число 2 
// не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число, отличное от нуля");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());

if (b % a == 0)
{
    Console.WriteLine("Второе число кратно первому");
}
else
{
    Console.WriteLine($"Второе число не кратно первому, остаток {b % a}");
}
