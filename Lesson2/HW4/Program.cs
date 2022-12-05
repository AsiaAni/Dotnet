// int Factorial(int n)
// {
// if (n ==1) return 1;
// else return n * Factorial(n-1);
// }
// int Factorial(int n);
// Console.WriteLine(Factorial(5));

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// double num2 = Convert.ToDouble(Console.ReadLine());

// double Method1(double a, double b)
// {
//     return Math.Pow(a, b);
// }

// Console.WriteLine(Method1(num1, num2));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// int Method2(int num)
// {
//     int sum = 0;
//     while (num > 9)
//     {
//         sum += num % 10;
//         num = num / 10;
//     }
//     if (num < 9)
//     {
//         sum += num;
//     }

//     return sum;

// }

// Console.WriteLine(Method2(num1));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int sizeArray = 8;
// int[] array = new int[sizeArray];

// int[] Method3(int[] fillingArray)
// {
//     for (int i = 0; i < fillingArray.Length; i++)
//     {
//   fillingArray[i]= new Random().Next(1,10);
//     }
// return fillingArray;
// }

// void Method4(int[] printArray)
// {
//    for (int i = 0; i < printArray.Length; i++)
//     {
//   Console.Write(printArray[i] + " ");
//     }
// }

// Method4(Method3(array));