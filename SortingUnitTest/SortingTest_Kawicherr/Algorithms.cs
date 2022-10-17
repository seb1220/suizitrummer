﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                throw new Exception("invalid range: " + min + " - " + max);

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
            return array;
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
            Console.WriteLine("ich will sterben");
        }

        private void QuickSort(int start, int end)
        {

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
            if (index * 2 + 1 >= array.Length - sorted - 1)
                return;
            
            if (array.Length > index * 2 + 1 && array[index] < array[index * 2 + 1]) {
                (array[index], array[index * 2 + 1]) = (array[index * 2 + 1], array[index]);
                if ((index * 2 + 1) * 2 + 1 < array.Length)
                    Heapify((index * 2 + 1) * 2 + 1, sorted);
            }
            if (array.Length > index * 2 + 2 && array[index] < array[index * 2 + 2])
            {
                (array[index], array[index * 2 + 2]) = (array[index * 2 + 2], array[index]);
                if ((index * 2 + 2) * 2 + 1 < array.Length)
                    Heapify((index * 2 + 2) * 2 + 1, sorted);
            }
        }

        public int this[int i]
        {
            get
            {
                return array[i];
            }
            set
            {
                array[i] = value;
            }
        }
    }
}
