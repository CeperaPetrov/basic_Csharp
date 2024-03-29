internal class Program
{
    /// <summary>
    /// Прочитаем число из консоли и обработаем ошибки
    /// </summary>
    /// <returns>Введенное пользователем число</returns>
    private static int ReadNumber(string prompt = "")
        {
            int num;
            while (true)
            {
                Console.WriteLine(value: prompt);

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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
{
    int num = ReadNumber("Введите число из отрезка [10, 99]:");
    if (num < 10 || num > 99) {
        Console.WriteLine("ВНИМАНИЕ! Введенное число выходит за пределы допустимого диапазона.");
    }
    else {
        int first = num / 10;
        int second = num % 10;
        int max = first;
        if (second>max) max = second;
        Console.WriteLine("Наибольшей цифрой в числе "+ num + " является цифра " + max);
    }
}
}