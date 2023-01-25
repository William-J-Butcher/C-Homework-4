// Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine();
Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int exponent = 1;

for (int i = 0; i < numB; i++)
{
    exponent = exponent * numA;
}
Console.WriteLine($"A в степени B = {exponent}");
Console.WriteLine();