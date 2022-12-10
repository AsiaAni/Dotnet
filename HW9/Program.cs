// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int Numbers(int number)
// {

//     // int [] array = new array[num];
//     if (number == 0) return 0;
//     Console.Write((number)+ " ");

//     return Numbers(number-1);
// }

// Numbers(m);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int sum = 0;
// int Numbers(int first, int end)
// {
//     if (first < 0 && end < 0)
//         Console.WriteLine("Отсутствуеют натуральные числа");

//     else if (first > end) return 0;
//     sum += first;
//     return Numbers(first + 1, end);

// }

// Numbers(a, b);
// Console.WriteLine(sum);

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ack(int n, int m)
// {
// if (n == 0) return m+1;
// else if (m == 0) return Ack(n-1,1);
// return Ack(n-1,Ack (n, m-1));
// }
// Console.WriteLine(Ack(2,3));
