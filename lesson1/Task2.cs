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
    /// Вычисление положения точки на декартовой системе координат
    /// </summary>
    /// <param name="x">Координата по оси абсцисс</param>
    /// <param name="y">Координата по оси ординат</param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    private static string CartesianQuadrants(int x, int y)
    {
        if (x > 0 && y > 0) return "I";
        if (x < 0 && y > 0) return "II";
        if (x < 0 && y < 0) return "III";
        if (x > 0 && y < 0) return "IV";
        if (x == 0 && y != 0) return "Abscissa";
        if (x != 0 && y == 0) return "Ordinate";
        return "Center";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        int x = ReadNumber("Введите координату X:");
        int y = ReadNumber("Введите координату Y:");

        if ((x == 0) || (y == 0)) {
            Console.WriteLine("Недопустимые координаты. Точка расположена на осях или в центре.");
            return;
        }

        string quadrant = CartesianQuadrants(x, y);

        Console.WriteLine("Точка с координатами (" + x + "," + y + ") расположена в "+ quadrant + " координатной четверти.");  
    }
}