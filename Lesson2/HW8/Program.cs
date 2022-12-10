// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];

// int[,] Method1(int[,] fillingArray)
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

// void Method2(int[,] printArray)
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

// int[,] Method3(int[,] ar) 
// { 
//     for (int i = 0; i < ar.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < ar.GetLength(1)-1; j++) 
//         { 
//             if (ar[i, j] <= ar[i, j + 1]) 
//             { 
//                 int temp = ar[i, j]; 

//                 ar[i, j] = ar[i, j + 1]; 
//                 ar[i, j + 1] = temp; 
//             } 

//         } 
//     } 
//     return ar; 
// }

// Method2(Method1(matrix));
// Console.WriteLine(" ");
// Method2(Method3(matrix));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
//     double[] array = new double[printArray.GetLength(0)];
//     {
//         for (int i = 0; i < printArray.GetLength(0); i++)
//         {
//             for (int j = 0; j < printArray.GetLength(1); j++)
//             {
//                 array[i] += printArray[i, j];
//             }
//         }

//         double min = 0;
//         int minIndex = 0;
//         for (int i = 0; i < array.Length; i++)

//         {
//             if (min > array[i])
//             min = array[i];
//             minIndex = i;
//         }
//         Console.WriteLine("Наименьшая сумма элементов находится в строке " + (minIndex+1) + " она равна " + array[minIndex]);
//     }
// }
//     Method2(Method1(matrix));
//     Method3(matrix);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int m = 2; 
// int n = 2; 

// int[,] array = {{2,4} , {3, 2}}; 
// int[,] array1 = {{3,4} , {3, 3}}; 
// int [,] workArrays = new int[m, n]; 
// PrinArray(array); 
// PrinArray(array1); 

// PrinArray(WorkMatrix(array, array1,workArrays)); 

// int[,] WorkMatrix(int[,] matrixOne,int[,] matrixTwo,int[,] workMatrix) 
// { 
//     for (int i = 0; i <matrixOne.GetLength(0); i++) 
//     { 
//         for (int j = 0; j < matrixOne.GetLength(1); j++) 
//         { 
//             workMatrix[i,j] = 0; 
//             for (int k = 0; k <matrixOne.GetLength(1); k++) 

//            workMatrix[i,j] += matrixOne[i,k]*matrixTwo[k,j]; 
//         } 

//     } 
//     return workMatrix; 
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
//     Console.WriteLine(""); 
// }


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] array = new int[2, 2, 2];
// void Method1(int[,,] array2)
// {
//     for (int i = 0; i < array2.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2.GetLength(2); k++)
//             {
//                 array2[i, j, k] = new Random().Next(10, 99);
//             }
//         }
//     }
// }

// void Method2(int[,,] array3)
// {
//     for (int i = 0; i < array3.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3.GetLength(2); k++)
//             {
//                 Console.WriteLine(array3[i,j,k] + " (" + i + "," + j + "," + k + ")");
//             }
//         }
//     }
// }

// Method1(array);
// Method2(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int [,] array = new int [4, 4];  
// FillArraySpirally(array); 
 
// void PrintArray(int [,] arrayToPrint){ 
//     for (int i = 0; i<arrayToPrint.GetLength(0); i++){ 
//         Console.WriteLine(); 
//         for (int j = 0; j<arrayToPrint.GetLength(1); j++){ 
//             Console.Write(arrayToPrint[i,j]+ "\t"); 
//         } 
//     } 
// Console.WriteLine(); 
// } 
 
// void FillArraySpirally(int [,] arrayToFill){ 
//     int width = arrayToFill.GetLength(1), height = arrayToFill.GetLength(0); 
//     int iBegin = 0, iFinal = 0, jBegin = 0, jFinal = 0;             //Инициализируем отступы от краёв прямоугольника 
//     int i = 0, j = 0, currentElement = 1; 
//     while(currentElement<= width*height){                              
//         arrayToFill[i,j] = currentElement; 
 
//         if (i == iBegin && j < width - jFinal - 1)                    //Если можно пойти вправо 
//             j++;                                                      //Идём вправо 
//         else if (j == width - jFinal - 1 && i < height - iFinal - 1)  //Иначе если можно пойти вниз 
//             i++;                                                      //Идём вниз 
//         else if (i == height - jFinal - 1 && j > jBegin)              //Иначе если можно пойти влево 
//             j--;                                                      //Идём влево 
//         else                                                          //Иначе 
//             i--;                                                      //Идём вверх 
 
//     if ((i == iBegin + 1) && (j == jBegin) && (jBegin != width - jFinal - 1)){ //Если находимся на второй строке в первом столбце  
//             iBegin++;                                                          //Увеличиваем отступы от краёв прямоугольника 
//             iFinal++; 
//             jBegin++; 
//             jFinal++; 
//         } 
//         currentElement++; 
//     } 
// PrintArray(arrayToFill); 
// }