using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        string? input;
        while (true)
        {
            Console.WriteLine("Введите чило (Выход 'q' или 'Q'):");

            input = Console.ReadLine();

            if (input == "q") break;
            if (input == "Q") break;

            int num;
            if (int.TryParse(input, out num))
            {
                int sum = CalcSumOfDigit(num);
                if (sum % 2 == 0) {
                    Console.WriteLine("Четная сумма цифр. ВЫХОД.");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Внимание! Ошибка ввода. Ввведите чилсо или 'q' для выхода.");
            }

        }

        return;
    }

    private static int CalcSumOfDigit(int num)
    {
        int sum = 0;

        while (num > 0) {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}