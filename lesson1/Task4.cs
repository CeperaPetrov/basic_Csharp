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
        int num = ReadNumber("Введите натуральное число N:");

        if (num < 1) { // исключим 0, ибо спорный
            Console.WriteLine("Ошибка ввода. Необходимо ввести натуральное число!");
            return;
        }

        string strnum = Convert.ToString(num);

        for (int i = 0; i < strnum.Length; i++) {
            Console.Write(strnum[i]);
            if ((i + 1) < strnum.Length) {
                Console.Write(",");
            }
        }
    }
}