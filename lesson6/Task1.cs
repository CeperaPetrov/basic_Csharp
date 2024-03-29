public class Program
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="v1"></param>
    /// <param name="v2"></param>
    /// <returns></returns>
    private static char[,] GenerateArray(int v1, int v2)
    {
        char[,] array = new char[v1, v2];
        var random = new Random();
        for (int i = 0; i < v1; i++)
        {
            for (int j = 0; j < v2; j++)
            {
                array[i, j] = (char)random.Next(32, 127);
            }
        }
        return array;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        char[,] chArray = GenerateArray(5, 5);

        string result = Array2StrFor(chArray);
        Console.WriteLine("array to string using 'for' loop:");
        Console.WriteLine(result);


        result = Array2StrForeach(chArray);
        Console.WriteLine("array to string using 'foreach' loop:");
        Console.WriteLine(result);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string Array2StrFor(char[,] array)
    {
        string result = "";
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j];
            }
        }
        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static string Array2StrForeach(char[,] array)
    {
        string result = "";
        foreach (char ch in array)
        {
            result += ch;
        }
        return result;
    }
}