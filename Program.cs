using System;

namespace MinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 6, -3, 5, 7 };
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (min> array[i])
                {
                    min = array[i];
                }
            }

            Console.WriteLine("il valore minimo è: " + min);
            
            Console.ReadKey();
        }
    }
}
