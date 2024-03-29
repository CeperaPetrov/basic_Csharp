internal class Program
{
    private static int[] GenerateArray(int size)
    {
        int[] array = new int[size];
        var random = new Random();
        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 100);
        }
        return array;
    }

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

    private static void RecursiveReversePrint(int[] array, int counter)
    {
        if (array.Length == counter)
            Console.Write("[");

        if (--counter < 0) return;

        Console.Write(array[counter]);
        if (counter > 0)
            Console.Write(",");
        RecursiveReversePrint(array, counter);

        if (counter == 0)
        {
            Console.Write("]");
            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {


        int[] array = GenerateArray(10);
        Console.WriteLine("Исходный массив:");
        Print(array);

        Console.WriteLine("Разворот массива:");
        RecursiveReversePrint(array, array.Length);
    }
}