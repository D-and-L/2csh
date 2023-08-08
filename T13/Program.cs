// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Writeline("введите число");
// int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число"); // 11
		
int num = Convert.ToInt32(Console.ReadLine());
int c = num;		
Console.WriteLine($"{c}".Length);
int v = ($"{c}".Length);

switch (v)
{
    case 3:
        int a = num % 10;
        Console.WriteLine($"{a}");
        break;
    case 4:
        int b = num % 100;
        int b1 = b / 10;
        Console.WriteLine($"{b1}");
        break;
    case 5:
        int d = num / 100;
        int d1 = d % 10;
        Console.WriteLine($"{d1}");
        break;
    case 6:
        int e = num / 1000;
        int e1 = e % 10;
        Console.WriteLine($"{e1}");
        break;
    case 7:
        int f = num / 1000;
        int f1 = f % 100;
        int f2 = f1 / 10;
        Console.WriteLine($"{f2}");
        break;
    case 8:
        int h = num / 100000;
        int h1 = h % 10;
        Console.WriteLine($"{h1}");
        break;
    case 9:
        int g = num / 1000000;
        int g1 = g % 10;
        Console.WriteLine($"{g1}");
        break;
    default:
        Console.WriteLine("нет третьей цифры");
        break;




}