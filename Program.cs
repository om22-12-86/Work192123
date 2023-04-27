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








