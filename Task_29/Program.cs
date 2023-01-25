// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine();
Console.WriteLine("Программа выводит массив из N элементов случайных чисел");
Console.Write("Введите любое целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[] array = new int[new Random().Next(0, num)];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, num);
    // Console.WriteLine(array[i]);
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine();