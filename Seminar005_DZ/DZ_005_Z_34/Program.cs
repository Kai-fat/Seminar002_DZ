// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Ведите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size]; //объявляю новый массив
NewArray(array);
PrintArray(array);
EvenNums();
void EvenNums()
{
int count = 0;
for (int j = 0; j < array.Length; j++)   //проверяем на четность
    if (array[j] % 2 == 0)
        count++;
Console.WriteLine($"чисел всего {array.Length}, {count} из них четные");
}

void NewArray(int[] array)  // создаем новый массив
{
    for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] array)
{
    foreach (int el in array)   //этот цикл делаем для просмотра 
        Console.Write($"{el} ");
}

// int count =0;
// for(int j = 0; j <array.Length; j++)
// if(array [j] % 2 == 0)
// count ++;
// Console.WriteLine($"всего {array.Length} числа, {count} из них четные");
