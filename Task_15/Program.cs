// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите цифру: ");
int Num;
Num = Convert.ToInt32(Console.ReadLine());
if ( Num > 5 & Num < 8)
{
    Console.WriteLine("Выходной");
}
if (Num < 6)
{
    Console.WriteLine("Не выходной");
}
// В данной задаче не разобрался как сделать вариант ответа при ошибочном значении, например 9. Я делал третью проверку
// ставил оператор else с сообщением " ошибка", но в терминале выводилось "Выходной" и "ошибка", я так понял, компьютер 
//  не видит эту третью проверку if /else. Как сделать так, чтобы выводилось правильно сообщение об ошибочной цифре? 