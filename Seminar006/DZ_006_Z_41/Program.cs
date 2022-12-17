// // Задача 41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2       1, -7, 567, 89, 223-> 3
// int[] NewArray()
// {
//     Console.WriteLine("Сколько чисел планируете ввести?");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите желаемые числа");
//     int[] nums = new int[a];
//     for (int i = 0; i < nums.Length; i++)
//     {
//         nums[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return nums;
// }
// void CreateArray()
// {
//     int[] nums = NewArray();
//     int count = 0;
//     foreach (int i in nums)
//         if (i > 0)
//             count++;
//     string x = string.Join(", ", nums);
//     Console.WriteLine(x);
//     Console.WriteLine($"Количество положительных чисел = {count}");
// }
// CreateArray();

// void FillArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }
// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.Write(col[position]);
//         position++;
//     }
// }

// int index0f(int[] collection, int found)
// {
//     int count = collection.Length;
//     int index = 0;
//     int position = -1;
//     while(index < count)
//     {
//         if(collection[index] == found)
//         {
//              position = index;
//              break;
//         }
//         index++;
//     }
//     return position;
// }

// int[] array = new int[10];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();

// int pos = index0f(array, 4);
// Console.WriteLine(pos);

