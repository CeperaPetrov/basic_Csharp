using System.Runtime.CompilerServices;

internal class Program
{
    /// <summary>
    ///  Печать одномерного массива
    /// </summary>
    /// <param name="array"> одномерный массив для печати</param>
    private static void Print(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(",");
            }
            Console.Write(array[i]);
        }
        Console.Write("]");
        Console.WriteLine();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    private static int[] GetRandomArray(int n)
    {
        int[] temp = new int[n];
        var random = new Random();
        
        for (int i = 0; i < n; i++)
            temp[i] = random.Next(100, 1000);

        return temp;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    private static int CountAmountOfEvenElements(int[] array)
    {
        int count = 0;
        foreach (int num in array) {
            if (num % 2 == 0) count++;
        }
        return count;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="args"></param>
    private static void Main(string[] args)
    {
        int[] array = GetRandomArray(20);

        Console.WriteLine("Произвольный массив");
        Print(array);

        int amount = CountAmountOfEvenElements(array);
        Console.WriteLine("Количество четных чисел в массиве: " + amount);

        return;
    }
}