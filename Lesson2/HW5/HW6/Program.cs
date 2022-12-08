// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


// Console.WriteLine("Введите размер массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num1];

// int[] Method1(int[] fillingArray)
// {
//     for (int i = 0; i < fillingArray.Length; i++)
//     {
//         Console.Write("Введите число: ");
//         fillingArray[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return fillingArray;
// }

// void Method2(int[] printArray)
// {
//     for (int i = 0; i < printArray.Length; i++)
//     {
//         Console.Write(printArray[i] + " ");
//     }
// }
// void Method3(int[] num)
// { int sum = 0;
//     for (int i = 0; i < num.Length; i++)
//     {

//    if (num[i] > 0)
//         {
//             sum ++;
//         }

//     } 
//     Console.WriteLine(sum);
// }
// Method2(Method1(array));
// Console.WriteLine();
// Method3(array);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("Введите значение координаты K1 ");
// int k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты B1 ");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты K2 ");
// int k2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите значение координаты B2 ");
// int b2 = Convert.ToInt32(Console.ReadLine());

// void Method4(double k1, double b1, double k2, double b2)
// {
//     if (k1 == k2 && b1 == b2)
//     { Console.WriteLine("Линии совпадают "); }
//     else if (k1 == k2)
//     { Console.WriteLine("Линии параллельны "); }
//     else
//     {
//         double x = (b2 - b1) / (k1 - k2);
//         double y = k1 * x + b1;
//         Console.WriteLine("Линии пересекаются в точке: " + x + " " + y);
//     }
// }
// Method4(k1, b1, k2, b2);
