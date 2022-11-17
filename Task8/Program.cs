// Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число:"); 
int N = int.Parse(Console.ReadLine());
int i = 1;  
   
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		
	}
	if (i >= N)
	{
		break;
	}
	i++;
}
