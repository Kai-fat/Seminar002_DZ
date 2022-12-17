// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.            // 0,5 7 -2 -0,2

                            // 1 -3,3 8 -9,9

                            // 8 7,8 -7,1 9


Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int cols = Convert.ToInt32(Console.ReadLine());
double [,] array = new double [rows, cols];
FillArray(array);
PrintArray(array);


void FillArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        for (int j=0;j<array.GetLength(1);j++)
            array[i,j] = Convert.ToDouble(new Random().Next(-100, 100))/10;
    Console.WriteLine();
}

void PrintArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
    {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3}\t");
        Console.WriteLine();  
    }
    Console.WriteLine();
}














// // Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и 
// //замените эти элементы на их квадраты.
// // Например, изначально массив
// //  выглядел вот так: 147259238424   
// // новый выглядит так 1472581298424

// Console.WriteLine("Введите количество строк двумерного массива");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов двумерного массива");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//         for (int j=0;j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-20,21);
//     Console.WriteLine();
// }

// void ChangeArray(int[,] array)
// {
//     for (int i=1;i<array.GetLength(0);i++)
//         for (int j=1;j<array.GetLength(1);j++)
//             if (i%2 != 0 && j%2 != 0) // если индекс строки не четный и индекс столбца не четные то
//             {
//                 array[i,j] = array[i,j]*array[i,j];  // то умножаем самого на себя
//             }
//     Console.WriteLine();
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0;i<array.GetLength(0);i++)
//     {
//         for (int j=0;j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3}\t");
//         Console.WriteLine();  
//     }
//     Console.WriteLine();
// }