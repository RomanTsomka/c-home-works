// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int num_1, num_2;
Console.WriteLine("Введите число: ");
num_1 = Convert.ToInt32(Console.ReadLine());
num_2 = (num_1 / 10) % 10;
Console.WriteLine(num_2);
