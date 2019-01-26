using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleSort_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            CYCLESORT c = new CYCLESORT();
            c.cyclesort();
        }
    }
    class CYCLESORT
    {
        public void cyclesort()
        {
            int[] array = new int[5] { 2, 4, 5, 1, 3 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                int item = array[i];
                int pos = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < item)
                    {
                        pos++;
                    }
                }
                if (pos == i)
                {
                    continue;
                }
                while (item == array[pos])
                {
                    pos++;
                }
                int var = item;
                item = array[pos];
                array[pos] = var;
                while (pos != i)
                {
                    pos = i;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] < item)
                        {
                            pos++;
                        }
                    }
                    while (item == array[pos])
                    {
                        pos++;
                    }
                    int temp = item;
                    item = array[pos];
                    array[pos] = temp;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
