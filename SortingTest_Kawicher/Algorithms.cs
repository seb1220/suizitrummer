using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{

        private int[] array;

        int[] CreateRandoms(int min, int max, int count, bool duplicates)
        {
            Random rand = new Random();
            if (max - min < 1 || max - min < count)
                return null;

            array = new int[count];
            while (array.Length < count)
            {
                int newInt = rand.Next(min, max);
                if (array.Contains(newInt) && !duplicates)
                    continue;
                array.Append(newInt);
            }

            return array;
        }

        void Print()
        {
            foreach (var VARIABLE in array)
            {

            }
        }

        void SetRandoms(int[] a)
        {
            array = new int[a.Length];
            a.CopyTo(array, 0);
        }

        int[] GetRandoms()
        {
            return array;
        }

        void BubbleSort()
        {

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
			HeapSort(0);
        }

		private void HeapSort(int sorted)
        {
			for (int i = (array.Lenght - sortd -1) / 2; i > 0; i--)
            {
				if (array[i * 2 + 1] > array[i])
                {
                    array[i], array[i * 2 + 1] = array[i * 2 + 1], array[i];
                }
            }
            array[0], array[array.Lenght - 1] = array[array.Lenght - 1],  array[0];
            HeapSort(sorted + 1);
        }
	}
}
