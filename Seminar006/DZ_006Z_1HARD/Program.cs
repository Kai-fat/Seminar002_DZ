// задача 1 - HARD необязательная. На вход программы подаются одно целое число. Составьте список чисел Фибоначчи,
//  в том числе для отрицательных индексов. Это по сути последовательность Негафибоначчи.
// Пример:
// для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int NegaFibonacci(int n)
{
    if (n == -1) return 1;
    else if (n == -2) return -1;
    else return NegaFibonacci(n + 2) - NegaFibonacci(n + 1);
}

for (int j = (-n); j <= -1; j++)  //считаем числа негафиб
    {
    
        Console.Write(NegaFibonacci(j)+ "," );

    }
Console.Write(0+"," );

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2); //в противном случае возвр фибоначи (n-1) + (n-2)
}
for (int i = 1; i <= n; i++)  //считаем числа фиб
{
    Console.Write(Fibonacci(i)+"," );
}