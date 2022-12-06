// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
// Через строку решать нельзя.
// 452 -> 11  82 -> 10   9012 -> 12

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
Console.WriteLine($"{Index(num)}");

int Index(int num)
{
    for (int i = num; i != 0; i = i / 10) sum +=i % 10;
        return sum;
}
