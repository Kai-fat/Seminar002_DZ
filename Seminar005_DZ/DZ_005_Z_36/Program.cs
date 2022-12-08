// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19        [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива");
int num = Convert.ToInt32(Console.ReadLine());
NewArray(num);

void NewArray(int num)
{
    int sum = 0;
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(1, 100);
        if (i % 2 != 0)       /// 72 11 57 72 76 10
            sum += array[i];    //0  1  2  3  4  5     sum = sum+array[i]
    }
    string str = string.Join(", ", array); // соединяем элементы массива через разделитель в нашем случае(,)

    Console.WriteLine($"[{str}]");
    Console.WriteLine($"Сумма элементов = {sum}");
}










