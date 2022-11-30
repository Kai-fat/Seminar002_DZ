// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write(" Введите день недели ");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{
    case 1:
        Console.WriteLine("No");
        break;
    case 2:
        Console.WriteLine("No");
        break;
    case 3:
        Console.WriteLine("No");
        break;  
    case 4:
        Console.WriteLine("No");
        break;
    case 5:
        Console.WriteLine("No");
        break;
    case 6:
        Console.WriteLine("Yes");
        break;
    case 7:
        Console.WriteLine("Yes");
        break;
    default:
        Console.WriteLine("Нет такого дня");
        break;
}