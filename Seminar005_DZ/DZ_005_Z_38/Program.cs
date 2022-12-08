// Задача 38: Задайте массив случайных вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Ведите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

double[] array = new double[num];
    for (int i = 0; i < num; i++)
    
        array[i] = new Random().Next(1, 100);

        Console.WriteLine(array);

