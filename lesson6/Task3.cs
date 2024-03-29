public class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите тестируемую строку:");
        string? input = Console.ReadLine();

        // Вызов метода для проверки, является ли строка палиндромом
        if (input is null)
        {
            Console.WriteLine("Внимание! Ничего не введено.");
        }
        else
        {
            string message = "Строка '" + input + "' ";
            if (!IsPalindrom(str: input))
            {
                message += "не ";
            }
            message += "являетя палиндромом";
            // Вывод результата
            Console.WriteLine(message);
        }
    }
    private static bool IsPalindrom(string str)
    {

        var word = str.ToLower();

        var inputArray = word.ToArray();
        var reversedArray = inputArray.Reverse().ToArray();

        return inputArray.SequenceEqual(reversedArray);
    }
}