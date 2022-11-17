internal class NewBaseType
{
    private static void Main(string[] args)
    {
        int num_1, num_2, num_3;
        Console.WriteLine("Введите три числа");
        num_1 = Convert.ToInt32(Console.ReadLine());
        num_2 = Convert.ToInt32(Console.ReadLine());
        num_3 = Convert.ToInt32(Console.ReadLine());

        int max = num_1;

        if (num_1 > max) max = num_1;
        if (num_2 > max) max = num_2;
        if (num_3 > max) max = num_3;

        Console.Write("Наибольшее число = ");
        Console.WriteLine(max);


    }
}

internal class Program : NewBaseType
{
}