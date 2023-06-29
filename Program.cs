using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 50, min = 1, max = 99;

            //int[] array = { 50, 4, 3, 67, 95, 18, 26, 4, 20, 13, 1, 202, 46 };

            int[] array = new int[size];
            
            Console.WriteLine("Unsorted Array");
            array = FillArray(size, min, max);
            DisplayArray(array);
            Console.WriteLine("The array was sorted using Insertion sort");

            InsertionSort(array);
            DisplayArray(array);
        }

        static int[] FillArray(int size, int min, int max)
        {
            int[] array = new int[size];
            int temp;
            bool found;

            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                do
                {
                    temp = random.Next(min, max + 1);
                    found = false;

                    for (int j = 0; j < temp; j++)
                    {
                      found = true;
                        j = i;
                    }

                    if (found == false)
                        array[i] = temp;
                } while (found == true);
            }
            return array;
        }
        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}]{1},", i, array[i]);
            }

            Console.WriteLine("[{0}]{1},", array.Length - 1, array[array.Length - 1]);

        }


        static void InsertionSort(int[] array)
        {
            int temp;

            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int x = i + 1; x > 0; x--)
                {
                    if(array[x - 1] > array[x])
                    {
                        temp = array[x - 1];
                        array[x - 1] = array[x];
                        array[x] = temp;
                    }
                }    
            }
        }
    }
}
