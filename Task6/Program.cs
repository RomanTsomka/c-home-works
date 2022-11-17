internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("Введенное число является четным");
        }
        else
        {
            Console.WriteLine("Введенное число являетс нечетным");
        }
    }
}
