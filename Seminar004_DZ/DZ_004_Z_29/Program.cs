// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и 
// далее выводит массив на экран в одну строку.
void ChekArray()
{
Console.WriteLine("Введите массив из восьми чисел");
int[] nums = new int[8];
for (int i = 0; i < 8; i++)
{
    nums[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"[{nums[0]},{nums[1]},{nums[2]},{nums[3]},{nums[4]},{nums[5]},{nums[6]},{nums[7]}]");
}
ChekArray();
