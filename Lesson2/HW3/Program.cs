
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// void Method(int count)

// {
// int num1 = count/10000;
// int num2 = (count/1000)%10;
// int num4 = (count%100)/10;
// int num5 = count%10;

//  if (num1 == num5 && num2 == num4)
//  Console.WriteLine("Число является палиндромом");
//  else 
//   Console.WriteLine("Число не является палиндромом");
// }

// Method(14212);
// Method(12821);
// Method(23432);

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// Console.WriteLine ("Введите значение координаты X1 ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение координаты Y1 ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение координаты Z1 ");
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите значение координаты X2 ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение координаты Y2 ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение координаты Z2 ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double Method2(int x1, int y1, int z1, int x2, int y2, int z2)
// {
// double distance; 
//     return distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// }

// Console.WriteLine($"Координты в 3D пространстве - {Math.Round (Method2(x1, y1, z1, x2, y2, z2), 3)}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Write("Введите число: ");

// int n = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[n];
// double count = 0;
// Method3(array);
// void Method3(double[] number)
// {
//     foreach (double i in number)
//     {
//         count++;
//         Console.WriteLine(Math.Pow(count,3));
//     }

// }

