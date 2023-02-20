using System;

namespace laba2_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int c = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[c];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < c; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nВведенный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; ");
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int k = arr[i];
                int j = i - 1;
                while(j>=0 && arr[j] > k)
                {
                    arr[j + 1] = arr[j];
                    arr[j] = k;
                    j--;
                }
            }
            
             Console.Write("\nОтсортированный массив: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "; " );
            }
            
        }
    }
}
