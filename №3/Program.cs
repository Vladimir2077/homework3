﻿//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i=1;i<=n;i++)
{
int cube = i*i*i;
Console.WriteLine($"{cube}");
}
