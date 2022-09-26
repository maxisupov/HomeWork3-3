// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.WriteLine("Введите координаты x1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y1: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z1: ");
int z = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты x2: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты y2: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты z2: ");
int z2 = int.Parse(Console.ReadLine());

int A = x2 - x;
int B = y2 - y;
int C = z2 - z;

double result = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между точками в 3D пространстве - {result:f3}");