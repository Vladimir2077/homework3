//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число число: ");
string number = Console.ReadLine();
if (number!.Length == 5)
{

  if (number[0]==number[4] || number[1]==number[3])
    Console.WriteLine($"Ваше число: {number} - палиндром");
    else Console.WriteLine($"Ваше число: {number} - не палиндром");
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число");
}
