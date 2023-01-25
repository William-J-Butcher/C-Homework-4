// Задача 27: 
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = num;
for (int i = 0; i < num; i++)
{
    int remainder = temp % 10;
    sum += remainder;
    temp /=  10;
}
Console.WriteLine($"Сумма цифр в числе = {sum}");
