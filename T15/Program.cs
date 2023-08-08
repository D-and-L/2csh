// Напишите программу, которая 

// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите номер дня недели");
int num = Convert.ToInt32(Console.ReadLine());

switch (num)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5: 
        Console.WriteLine("Опять работать(((");
        break;
    case 6:
    case 7:
        Console.WriteLine("Ураааа, можно спать!!!");
        break;



}