internal class Program
{
    private static void PrintDigits(int m, int n)
    {
        if (m <= n)
        {
            Console.Write(m);
            if (m < n) Console.Write(", ");
            PrintDigits(++m, n);
        }
    }
    private static void Main(string[] args)
    {

        Console.WriteLine("Введите число M:");
        int m = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите число N:");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintDigits(m, n);
    }
}