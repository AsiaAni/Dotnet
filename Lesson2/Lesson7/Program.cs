// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int m = 4; 
// int n = 7; 
// int[,] array = new int[m, n]; 

// PrinArray(FillArray(array)); 

// int[,] FillArray(int[,] arr) 
// { 

//     for (int i = 0; i < arr.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < arr.GetLength(1); j++) 
//         { 
//             arr[i, j] = new Random().Next(1, 11); 

//         } 
//     } 
//     return arr; 
// } 

// void PrinArray(int[,] ar) 
// { 
//     for (int i = 0; i < ar.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < ar.GetLength(1); j++) 
//         { 
//             Console.Write($"{ar[i, j]} "); 

//         } 
//         Console.WriteLine(""); 
//     } 
// }



// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] matrix = new int[3,4];
// for (int i = 0; i < 3; i++)
// {
//      for (int j = 0; j < 5; j++)
//       {
//           Console.Write($"{matrix[i, j]}  ");
//       }
// Console.WriteLine();
// }

// void PrintArray(int[,] matr);
// void FillArray(int[,] matr);
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; i < matrix.GetLength(1); j++)
//         {
//           matr[i, j] = new Random().Next(1,10);// m{1:10)
//         }
//      }
// }
// int [,] matrix = new int[3,4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();  
// }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)   // GetLength(0) - строки в массиве
// {
//     for (int j = 0; j < matr.GetLength(1); j++)  //   GetLength(1) - столбцы в массиве
//     {
//         matr[i, j] = new Random().Next(1, 10);
//     }
// }
// }
// int[,] matrix = new int [3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

// Console.WriteLine();

// void TransformArray (int[,] array)
// {
// for(int i = 0; i < array.GetLength(1); i++)
//             {
//                 int tmp = array[2, i];
//                 array[2, i] = array[0, i];
//                 array[0, i] = tmp;
//             }
//             for(int i = 0; i < array.GetLength(0); i++)
//             {
//                 for(int j = 0; j < array.GetLength(1); j++)
//                 {
//                     Console.Write(array[i,j] + " ");
//                 }
//                 Console.WriteLine();
//             }
// }
// TransformArray(matrix);

// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)   // GetLength(0) - строки в массиве
    {
        for (int j = 0; j < matr.GetLength(1); j++)  //   GetLength(1) - столбцы в массиве
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}
int[,] matrix = new int[4, 4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

Console.WriteLine();


// void TransformArray (int[,] array)
// {
//     if (array.GetLength(0)==array.GetLength(1)){
// {
//     for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         Console.Write($"{array[j, i]} ");
//     }
//     Console.WriteLine();  
// }
// }
//             }
//     else Console.WriteLine("Невозможно произвести замену");
// }
// TransformArray(matrix);

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125