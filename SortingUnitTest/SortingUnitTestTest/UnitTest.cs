using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SortingTest_Kawicher;
using System.Linq;

namespace SortingUnitTestTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void CreateRandomsTest()
        {
            Algorithms algorithms = new Algorithms();

            int min = 10;
            int max = 100;
            int count = 50;
            bool duplicates = false;
            algorithms.CreateRandoms(min, max, count, duplicates);
            int[] array = algorithms.GetRandoms();

            Assert.AreEqual(count, array.Length);
            Assert.IsTrue(array.Min() >= min);
            Assert.IsTrue(array.Max() <= max);

            if (duplicates)
                return;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j && array[i] == array[j])
                        Assert.Fail("dubpicates: " + array[i] + " and " + array[j]);
                }
            }
            
        }

        [TestMethod]
        public void BubbleSortTest()
        {
            Algorithms algorithms = new Algorithms();

            int min = 10;
            int max = 100;
            int count = 50;
            bool duplicates = false;
            algorithms.CreateRandoms(min, max, count, duplicates);
            algorithms.BubbleSort();
            int[] array = algorithms.GetRandoms();

            for (int i = 0; i < array.Length - 2; ++i)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }

        [TestMethod]
        public void QuickSortTest()
        {
            Algorithms algorithms = new Algorithms();

            int min = 10;
            int max = 100;
            int count = 50;
            bool duplicates = false;
            algorithms.CreateRandoms(min, max, count, duplicates);
            algorithms.QuickSort();
            int[] array = algorithms.GetRandoms();

            for (int i = 0; i < array.Length - 2; ++i)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }

        [TestMethod]
        public void HeapSortTest()
        {
            Algorithms algorithms = new Algorithms();

            int min = 10;
            int max = 100;
            int count = 50;
            bool duplicates = false;
            algorithms.CreateRandoms(min, max, count, duplicates);
            algorithms.HeapSort();
            int[] array = algorithms.GetRandoms();

            for (int i = 0; i < array.Length - 2; ++i)
            {
                Assert.IsTrue(array[i] <= array[i + 1]);
            }
        }
    }
}
