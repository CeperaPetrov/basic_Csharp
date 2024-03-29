internal class Program
{
    
    private static void ReverseClassic1(int[] array)
    {
        int temp;

        // реверсирование массива
        for (int i = 0; i < array.Length / 2; i++)
        {
            temp = array[i];
            array[i] = array[array.Length - i - 1];
            array[array.Length - i - 1] = temp;
        }

        return;
    }

    private static void ReverseClassic2(int[] array)
    {
        int temp;

        for (int i = 0, j = array.Length - 1; i < j; i++, j--)
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        return;
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
    private static int[] GetRandomArray(int n)
    {
        int[] temp = new int[n];
        var random = new Random();
        
        for (int i = 0; i < n; i++)
            temp[i] = random.Next(100);

        return temp;
    }
    private static void Main(string[] args)
    {
        int[] a = GetRandomArray(10);
        Console.WriteLine("Исходный массив");
        Print(a);
        
        Array.Reverse(a);
        Console.WriteLine("Развернули массив Array.Reverse(a)");
        Print(a);
        
        ReverseClassic1(a);
        Console.WriteLine("Развернули массив ReverseClassic1(a)");
        Print(a);

        ReverseClassic2(a);
        Console.WriteLine("Развернули массив ReverseClassic2(a)");
        Print(a);
        
        return;

    }
}