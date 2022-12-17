// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
// и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:   1 4 7 2
//                           5 9 2 3
//                           8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("задайте  искомое число в массиве");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];

FillArray(array);
PrintArray(array);
index0f(array, num);

void FillArray(int[,] array)   // создаем массив
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 30);
}

void PrintArray(int[,] array)   // выводим массив
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],3}\t");
        Console.WriteLine();
    }
}

bool index0f(int[,] array, int num)
{
    int ind1 = -1;
    int ind2 = -1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
            {
                ind1 = i;
                ind2 = j;
                Console.WriteLine($"Элемент {num} в массиве в строке {ind1} и столбце {ind2} ");
                return true;
            }
        }
    }
    Console.WriteLine($"элемента {num} в массиве нет");
    return false;
}


