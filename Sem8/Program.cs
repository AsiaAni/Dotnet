// int Factorial(int num)
// {
//     if (num ==1) return 1;
//     return num* Factorial(num - 1);
// }

// int x = Factorial(5);
// Console.WriteLine(x);

// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


// Console.WriteLine("Введите число: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int Numbers(int first, int end)
// {
    
//     // int [] array = new array[num];
//     if (first > end) return 0;
//     Console.Write((first)+ " ");

//     return Numbers(first+1, end);
// }

// Numbers(1, m);



// Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

// Console.WriteLine("Введите число 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int Numbers(int first, int end)
// {
//     if (first < 0 && end < 0)
//      Console.WriteLine("Отсутствуеют натуральные числа");
//     else if (first < 0 && end > 0)
//     return Numbers (1, end);
//     if (first > end) return 0;
//     Console.Write((first)+ " ");

//     return Numbers(first+1, end);
// }

// Numbers(a, b);

// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


// void task3()
// {
//     int N = int.Parse(Console.ReadLine());

//     Console.Write(summa(N));

//     int summa(int N)
//     {
//         if (N % 10 == 0)
//         {
//             return N;
//         }
//         return (N % 10) + summa(N / 10);
//     }
// }

// void task4()
// {
//     int A = new_value(), B = new_value();

//     Console.WriteLine(step(A,B));

//     int step(int A, int B)
//     {
//         if (B == 0)
//             return 1;
//         return A * step(A, B - 1);
//     }
// }
// int new_value()
// {
//     Console.WriteLine("Введите число");
//     return int.Parse(Console.ReadLine());
// }


// double DegreeOfNumber(int a, int b)// метод возведения в степень
// {
//     if(b == 0) // свойство степени 
//         return 1;
//     if(b % 2 == 1)
//         return a * DegreeOfNumber(a, b -1);
//         else
//         return DegreeOfNumber(a * a, b / 2);
// }
// Console.WriteLine(DegreeOfNumber(5,2));