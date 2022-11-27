Console.WriteLine("Введите число A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA>numB)
{
    Console.WriteLine("MAX число A " +numA);
    Console.WriteLine("MIN число B " +numB);
}
else
{
    Console.WriteLine("MAX число B " +numB);
    Console.WriteLine("MIN число A " +numA);
}