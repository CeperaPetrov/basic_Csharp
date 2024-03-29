internal class Program
{
    private static int ack(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else
        {
            if (n == 0)
                return ack(m - 1, 1);
            else
                return ack(m - 1, ack(m, n - 1));
        }
    }

    private static void Main(string[] args)
    {

        Console.WriteLine("Введите число M:");
        int m = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Введите число N:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(ack(m, n));
    }
}