using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		int[] array = {10, 6, 4, 8, 2};

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
