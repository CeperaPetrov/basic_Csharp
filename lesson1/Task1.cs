internal class Program
{
    /// <summary>
    /// Прочитаем число из консоли и обработаем ошибки
    /// </summary>
    /// <returns>Введенное пользователем число</returns>
    private static int ReadNumber()
        {
            int num;
            while (true)
            {
                Console.WriteLine(value: "Введите число:");

                string? input = Console.ReadLine();

                if (input is null or "")
                {
                    Console.WriteLine("ВНИМАНИЕ! Вы ничего не ввели, а нужно ввести число.");
                    continue;
                }

                if (int.TryParse(input, out num))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ОШИБКА! Введенные данные не являются числом!");
                }
            }
            return num;
        }
    private static void Main(string[] args)
    {
        int num = ReadNumber();
        Console.WriteLine("Кратно ли число " + num + " числам 23 и 7?");
        if ((num % 7 == 0) && (num % 23 == 0)) {
            Console.WriteLine("Yape!");
        }
        else {
            Console.WriteLine("Nope!");
        }     
    }
}