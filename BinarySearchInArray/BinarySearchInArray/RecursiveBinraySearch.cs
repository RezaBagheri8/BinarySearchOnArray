using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchInArray
{
    public class RecursiveBinarySearch
    {
        public int[] array;

        public RecursiveBinarySearch(int[] Inputarray)
        {
            array = new int[Inputarray.Length];
            array = Inputarray;
        }

        public void Search(int key, int first, int last)
        {
            int middle = (first + last) / 2;

            if (key == array[middle])
            {
                Console.WriteLine("True");
            }
            else if (first == last)
            {
                Console.WriteLine("False");
            }
            else if (first > last)
            {
                Console.WriteLine("False");
            }
            else if (key > array[middle])
            {
                Search(key, middle + 1, last);
            }
            else
            {
                Search(key, first, middle - 1);
            }
        }
    }
}
