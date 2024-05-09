using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
    public class Program
    {
        public static void Quicksort(int[] array, int p, int r)
        {
            int q;

            if (p < r)
            {
                q = Partition(array, p, r);
                Quicksort(array, p, q - 1);
                Quicksort(array, q + 1, r);
            }
        }

        public static int Partition(int[] array, int p, int r)
        {
            int x, i, temp;
            x = array[r];
            i = p - 1;

            for (int j = p; j <= r - 1; j++)
            {
                if (array[j] <= x)
                {
                    i++;

                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }


            }

            temp = array[i + 1];
            array[i + 1] = array[r];
            array[r] = temp;

            return i + 1;
        }

        static void Main(string[] args)
        {
            int[] array = { 57, 2, 15, 7, 12, 4, 3, 14, 53, 21, 64 };
          

            Quicksort(array, 0, array.Length -1);

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");

            }

            Console.ReadKey();
        }
    }
}
