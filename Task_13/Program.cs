// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int num_1, num_2;
Console.WriteLine("Введите число: ");
num_1 = Convert.ToInt32(Console.ReadLine());
if (num_1 < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

if (num_1 >= 100)
{
    num_2 = (num_1 / 10) % 10;
Console.WriteLine(num_2);
}