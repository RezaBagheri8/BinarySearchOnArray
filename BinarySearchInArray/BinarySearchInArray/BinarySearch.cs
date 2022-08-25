using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchInArray
{
    public class BinarySearch
    {
        public int[] array;
        public int first;
        public int last;
        public int middle;
        public bool flag = false;

        public BinarySearch(int[] Inputarray)
        {
            first = 0;
            array = new int[Inputarray.Length];
            array = Inputarray;
            last = array.Length - 1;
            middle = (first + last) / 2;
        }

        public bool Search(int key)
        {
            while (true)
            {
                if (key == array[middle])
                {
                    return true;
                }
                else if (last == first)
                {
                    return false;
                }
                else if (key > array[middle])
                {
                    first = middle + 1;
                    middle = (first + last) / 2;
                }
                else if (key < array[middle])
                {
                    last = middle - 1;
                    middle = (first + last) / 2;
                }
            }
        }
    }
}
