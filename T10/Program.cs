//  Напишите программу, которая 
//  1. принимает на вход трёхзначное число и 
//  2. на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трехзначное число.");
int num = Convert.ToInt32(Console.ReadLine());
int secth = num % 100;
int second = secth / 10;
Console.WriteLine($"{second}");