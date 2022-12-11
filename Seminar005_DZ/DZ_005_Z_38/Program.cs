// Задача 38: Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Ведите размер массива");
int num = Convert.ToInt32(Console.ReadLine());
double[] array = new double[num];
NewArray(array);
PrintArray(array);

void NewArray(double[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] = Convert.ToDouble(new Random().Next(10, 1000)) / 10;
}

void PrintArray(double[] array)
{
    foreach (double el in array)   
        Console.Write($"{el} ");
}
double max = Int32.MinValue;
double min = Int32.MaxValue;

for (int j = 0; j < array.Length; j++)   //ищем мин и мах элементы
{
    if (array[j] > max)
    {
        max = array[j];
    }
    if (array[j] < min)
    {
        min = array[j];
    }
}
Console.WriteLine($" MAX = {max} ,MIN = {min} ");
Console.WriteLine($"Разница  максимального и минимального элемента массива = {(max) - (min)} ");



