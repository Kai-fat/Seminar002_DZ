Console.WriteLine("Введите три числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
if (A > B && A > C) 
{
    Console.WriteLine("MAX = A " +A);
}
else if (B>A && B>C)
{
    Console.WriteLine("MAX = B " +B);
}
else
{
Console.WriteLine("MAX = C " +C);
}