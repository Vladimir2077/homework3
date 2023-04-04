//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int Read(string argument)
{
int number;
System.Console.WriteLine($"Введите: {argument}: ");
while((!int.TryParse(Console.ReadLine(), out number)))
{
System.Console.WriteLine("Это не число");
}
return number;
}

double Legth()
{
int x1 = Read("A1");
int y1 = Read("A2");
int z1 = Read("A3");
int x2 = Read("B1");
int y2 = Read("B2");
int z2 = Read("B3");
double Length = Math.Sqrt(Math.Pow( x1 - x2, 2 ) + Math.Pow( y1 - y2, 2 ) + Math.Pow( z1 - z2, 2));
return Length;
}

void Answer()
{
double L = Legth();
System.Console.WriteLine($"Длина отрезка = {L}");
}
Answer();