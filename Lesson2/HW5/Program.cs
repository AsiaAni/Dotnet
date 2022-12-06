// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите размер массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num1];

// int[] Method1(int[] fillingArray)
// {
//     for (int i = 0; i < fillingArray.Length; i++)
//     {
//         fillingArray[i] = new Random().Next(100, 999);
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

//    if (num[i]%2 == 0)
//         {
//             sum ++;
//         }

//     } 
//     Console.WriteLine(sum);
// }
// Method2(Method1(array));
// Console.WriteLine();
// Method3(array);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите размер массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[num1];

// int[] Method1(int[] fillingArray)
// {
//     for (int i = 0; i < fillingArray.Length; i++)
//     {
//         fillingArray[i] = new Random().Next(0, 99);
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
//     for (int i = 1; i < num.Length; i+=2)
//     {
//    sum += num[i];
//     } 
//     Console.WriteLine(sum);
// }
// Method2(Method1(array));
// Console.WriteLine();
// Method3(array);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Console.WriteLine("Введите размер массива: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// double[] array = new double[num1];

// double[] Method1(double[] fillingArray)
// {
//     for (int i = 0; i < fillingArray.Length; i++)
//     {
//         fillingArray[i] = new Random().Next(-10, 10);
//     }
//     return fillingArray;
// }

// void Method2(double[] printArray)
// {
//     for (int i = 0; i < printArray.Length; i++)
//     {
//         Console.Write(printArray[i] + " ");
//     }
// }

// void Method3(double[] num)
// {
//     double max = num[0];
//     double min = num[0];
//     for (int i = 1; i < num.Length; i ++)
//     {
//         if (num[i] > max)
//         max = num[i];
//         if (num[i] < min)
//         min = num[i];
//     }
    
//     Console.WriteLine(max-min);
// }
// Method2(Method1(array));
// Console.WriteLine();
// Method3(array);

