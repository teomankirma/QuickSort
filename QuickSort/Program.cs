using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 7, 25, 87, -30, -23, 134, 60, -147 };

            QuickSort.Sort(numbers);
            Console.Write("Quick Sort");
            Console.WriteLine(" ");
            Console.WriteLine(string.Join(" | ", numbers));

        }
    }
}
