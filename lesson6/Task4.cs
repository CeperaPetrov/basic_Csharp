class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Введите строку:");
        string? input = Console.ReadLine();
        if (input is null)
        {
            Console.WriteLine("Внимание! Ничего не введено.");
        }
        else
        {
            Console.WriteLine("Введена строка:");
            Console.WriteLine(input);
            Console.WriteLine("Перевернутая строка:");
            Console.WriteLine(ReverseWords(input));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private static string ReverseWords(string str)
    {
        string result = "";
        string[] awords = str.Split(' ');
        Array.Reverse(awords);
        foreach (string s in awords)
        {
            if (result != "") result += " ";
            result += s;
        }
        return result;
    }
}