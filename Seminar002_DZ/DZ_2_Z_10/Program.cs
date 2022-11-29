// Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа. Через строку решать нельзя.
Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
int InputSecondNumber(int N)
//int secondNumber = InputSecondNumber(N);
{
    int count;
    count = N % 100 / 10;
    return count;
}
int secondNumber = InputSecondNumber(N);
Console.Write($"Вторая цифра из {N} = {secondNumber}");