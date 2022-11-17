internal class Program
{
    private static void Main(string[] args)
    {
        int FerstNum, SecondNum;
        Console.WriteLine("Введите первое число: ");
        FerstNum = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        SecondNum = Convert.ToInt32(Console.ReadLine());

        if (FerstNum < SecondNum)
        {
            Console.WriteLine("{0} Наибольшее число", SecondNum);
        }
        else
        {
            Console.WriteLine("{0} Наибольшее число", FerstNum);
        }

    }
}