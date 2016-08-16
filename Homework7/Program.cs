using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class DynamicArray
    {
        private int[] Array;

        public DynamicArray(int[] array)
        {
            Array = array;
        }

        public void Display(int[] array)
        {
            foreach (int x in array)
            {
                Console.Write("{0,2} ", x);
            }
            Console.WriteLine();
        }

        public void Insert(int index, int val, ref int[] array)
        {

            // code here 
            int newIndex = Array.Length + 1;
            int[] tempArray = new int[newIndex];

            bool used = false;

            for (int i = 0; i <= Array.Length; i++)
            {
                if (i == index)
                {
                    used = true;
                }

                switch (used)
                {
                    case false:
                        tempArray[i] = array[i];
                        break;

                    default:
                        if (i == index)
                        {
                            tempArray[i] = val;
                        }
                        else
                        {
                            tempArray[i] = array[i - 1];
                        }
                        break;
                }

            }

            array = tempArray;

        }

        public void RemoveAt(int index, ref int[] array)
        {
            // code here
            int currentIndex = index;
            int[] tempArray = new int[array.Length - 1];

            bool used = false;

            for (int x = 0; x <= array.Length - 1; x++)
            {
                if (x == index)
                {
                    used = true;
                }
                switch (used)
                {
                    case false:
                        tempArray[x] = array[x];
                        break;

                    default:
                        if (x == index)
                        {
                            break;
                        }
                        else
                        {
                            tempArray[x - 1] = array[x];
                        }
                        break;
                }
            }

            array = tempArray;
        }
    }

    class Arrays_InsDel
    {

        static void Main()
        {
            int[] array = new int[6] { 10, 20, 30, 40, 50, -1 };

            DynamicArray da = new DynamicArray(array);
            da.Display(array);

            da.Insert(2, 22, ref array);
            da.Display(array);

            da.RemoveAt(3, ref array);
            da.Display(array);

            Console.Write("Press Enter...");
            Console.ReadLine();
        }
    }
}
