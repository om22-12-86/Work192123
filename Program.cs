// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


//int x = new Random().Next(10000, 99999);
int x = 12821;
// int y = 12821;
// int c = 23432;

Console.Write("Является ли палиндромом x: ");
Console.WriteLine($"{x}");
int num1 = x % 10;
int num2 = x % 100 / 10;
int num3 = x % 10000 / 1000;
int num4 = x % 100000 / 10000;

Console.WriteLine($"{num1}");
Console.WriteLine($"{num2}");
Console.WriteLine($"{num3}");
Console.WriteLine($"{num4}");


 if (num1 == num4 && num2 == num3)
  {
    Console.WriteLine("Да.");
  }
  else
  {
    Console.WriteLine("Нет.");
  }



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

System.Console.WriteLine("Вести х1 координату первой точки : ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Вести y1 координату первой точки : ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Вести z1 координату первой точки : ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Вести x2 координату второй точки : ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Вести y2 координату второй точки : ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.WriteLine("Вести z2 координату второй точки : ");
double z2 = Convert.ToDouble(Console.ReadLine());


double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 -y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine($"{Math.Round(result, 2)} ");








