// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = ConvertToInt32(Console.ReadLine());
// double [,] matrix = new double [m, n];

// double [,] Method1(double[,] fillingArray)
// {
//     for (int i = 0; i < fillingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < fillingArray.GetLength(1); j++)
//         {
//             fillingArray[i,j] = new Random().NextDouble()+ new Random().Next(-10, 10);
//         }
//     }
//       return fillingArray;
// }
// void Method2(double[,] printArray)
// {
//        for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//            Console.Write($"{Math.Round(printArray[i, j],1)} ");
//         }
//         Console.WriteLine();
//     }
// }
// Method2(Method1(matrix));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] matrix = new double [m, n];

// double [,] Method1(double[,] fillingArray)
// {
//     for (int i = 0; i < fillingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < fillingArray.GetLength(1); j++)
//         {
//             fillingArray[i,j] = new Random().Next(1, 10);
//         }
//     }
//       return fillingArray;
// }

// void Method2(double[,] printArray)
// {
//        for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//            Console.Write(printArray[i, j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }
// void Method3(double[,] printArray)
// {
//     int count = 0;
//     Console.WriteLine("Введите число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {

//             if (printArray[i, j] == num)
// {
// Console.WriteLine($"{num} находится в ячейке {i},{j} ");
// count++;
// } 
//         }
//     }

//        if (count == 0 ) Console.WriteLine($"Элемент отсутствует в массиве");
// }
// Method2(Method1(matrix));
// Method3(matrix);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] matrix = new double[m, n];

// double[,] Method1(double[,] fillingArray)
// {
//     for (int i = 0; i < fillingArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < fillingArray.GetLength(1); j++)
//         {
//             fillingArray[i, j] = new Random().Next(1, 10);
//         }
//     }
//     return fillingArray;
// }

// void Method2(double[,] printArray)
// {
//     for (int i = 0; i < printArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < printArray.GetLength(1); j++)
//         {
//             Console.Write(printArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void Method3(double[,] printArray)
// {
//     double[] array = new double[printArray.GetLength(1)];
//     {
//         for (int i = 0; i < printArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < printArray.GetLength(1); j++)
//             {
//                 array[j] += printArray[i, j];
//             }
//         }
//         for (int i = 0; i < array.Length; i++)
//         {
// array[i]/= array.Length;
// Console.WriteLine("Среднее арифметическое столбца "+ (i + 1) + "= " + Math.Round(array[i],1));
//         }
//     }
// }
//     Method2(Method1(matrix));
//     Method3(matrix);