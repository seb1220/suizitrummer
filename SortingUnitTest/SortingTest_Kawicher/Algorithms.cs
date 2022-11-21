using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SortingTest_Kawicher
{
    public class Algorithms
    {
        private int[] array;

        public int[] CreateRandoms(int min, int max, int count, bool duplicates)
        {
            Random rand = new Random();
            if (max - min < 1 || max - min < count)
                throw new AlgoException("invalid range: " + min + ", " + max);

            array = new int[count];
            for (int i = 0; i < count; i++)
            {
                int newInt = rand.Next(min, max);
                while (array.Contains(newInt))
                {
                    newInt = rand.Next(min, max);
                }
                array[i] = newInt;
            }

            return array;
        }

        public void Print()
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        public void SetRandoms(int[] a)
        {
            array = new int[a.Length];
            a.CopyTo(array, 0);
        }

        public int[] GetRandoms()
        {
            int[] a = new int[array.Length];
            array.CopyTo(a, 0);
            return a;
        }

        public void BubbleSort()
        {
            int lastChange = array.Length - 2;
            bool changed = true;

            while (changed)
            {
                changed = false;
                for (int i = 0; i < lastChange; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                        changed = true;
                    }
                }
            }
        }

        public void QuickSort()
        {
            QuickSort(0, array.Length - 1);
        }

        private void QuickSort(int start, int end)
        {
            int pivot = start;
            int i = start + 1;
            int j = end;
            bool iLocked = false;
            bool jLocked = false;
            
            while (i <= j)
            {
                iLocked = array[i] > array[pivot];
                jLocked = array[j] < array[pivot];
                
                if (iLocked && jLocked)
                {
                    (array[i], array[j]) = (array[j], array[i]);
                    iLocked = jLocked = false;
                }
                
                i += (iLocked ? 0 : 1);
                j -= (jLocked ? 0 : 1);
            }

            if (array[j] < array[pivot])
            {
                (array[pivot], array[j]) = (array[j], array[pivot]);
                pivot = j;
            }

            Thread t1 = new Thread(() => QuickSort(start, pivot - 1));
            Thread t2 = new Thread(() => QuickSort(pivot + 1, end));
            
            if (pivot - start > 0)
                t1.Start();
            if (end - pivot > 0)
                t2.Start();

            if (t1.IsAlive)
                t1.Join();
            if (t2.IsAlive)
                t2.Join();
        }

        public void HeapSort()
        {
            for (int sorted = 0; sorted < array.Length - 1; ++sorted)
            {
                for (int i = (array.Length - sorted - 2) / 2; i >= 0; i--)
                {
                    Heapify(i, sorted);
                }
                (array[0], array[array.Length - sorted - 1]) = (array[array.Length - sorted - 1], array[0]);
            }
        }

        private void Heapify(int index, int sorted)
        {
            if (index * 2 + 1 >= array.Length - sorted)
                return;
            
            Thread t1 = new Thread(() => Heapify((index * 2 + 1) * 2 + 1, sorted));
            Thread t2 = new Thread(() => Heapify((index * 2 + 2) * 2 + 1, sorted));
            
            if (array.Length > index * 2 + 1 && array[index] < array[index * 2 + 1]) {
                (array[index], array[index * 2 + 1]) = (array[index * 2 + 1], array[index]);
                t1.Start();
            }
            
            if (index * 2 + 2 >= array.Length - sorted)
                return;
            if (array.Length > index * 2 + 2 && array[index] < array[index * 2 + 2])
            {
                (array[index], array[index * 2 + 2]) = (array[index * 2 + 2], array[index]);
                t2.Start();
            }
            
            if (t1.IsAlive)
                t1.Join();
            if (t2.IsAlive)
                t2.Join();
        }

        public int this[uint i]
        {
            get
            {
                return array[i];
            }
            private set
            {
                array[i] = value;
            }
        }

        public bool this[string element]
        {
            get
            {
                if (!int.TryParse(element, out int intElement))
                    return false;

                foreach (int i in array)
                {
                    if (intElement == i)
                        return true;
                }

                return false;
                
            }
        }
    }
}
