// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Clear();
// Console.Write("Введите число: ");
// int num = 456;
// int num2 = num/10;
// int num3 = num2%10;
// int result = num3;
// Console.WriteLine(result);

// Console.Clear();
// Console.Write("Введите число: ");
// int num = 782;
// int num2 = num/10;
// int num3 = num2%10;
// int result = num3;
// Console.WriteLine(result);

// Console.Clear();
// Console.Write("Введите число: ");
// int num = 918;
// int num2 = num/10;
// int num3 = num2%10;
// int result = num3;
// Console.WriteLine(result);

// Console.Clear();
// Console.Write("Введите число: ");
// // int num = Convert.ToInt32(Console.ReadLine());
// int num = 32679;
// if (num >= 100)
// {
// int num2 = num%1000;
// int num3 = num2/100;
// Console.Write (num3);
// }
// else

// Console.WriteLine("третьей цифры нет");


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <=5)
{
    Console.WriteLine("Будний день");
}
else
{
    Console.WriteLine("Выходной день");
}