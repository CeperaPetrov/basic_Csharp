internal class Program
{
    private static string GenerateStr(int size = 0)
    {
        string result = "";
        var random = new Random();

        for (int i = 0; i < size; i++)
        {
            result += (char)random.Next(65, 91);
        }
        return result;
    }
    private static void Main(string[] args)
    {
        string strdata = GenerateStr(20);
        Console.WriteLine("Generated string:");
        Console.WriteLine(strdata);


        string result = strdata.ToLower();
        Console.WriteLine("String after conversion:");
        Console.WriteLine(result);
    }
}