using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayReversed();
        }
        static void ArrayReversed()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = new int[3];
            int counter = 0;
            for (int i = array1.Length - 1; i >= 0; i--)
            {
                array2[counter] = array1[i];
                counter++;
            }
            Console.Write(string.Join(",", array2));
        }
    }
}

