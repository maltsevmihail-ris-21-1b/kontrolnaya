using System.Diagnostics;

namespace kontrolnaya
{
    public class UnitTest1
    {
        [Fact]
        public void Bubble_Sort_Test()
        {
            int[] array = { 5, 3, 8, 4, 2 };

            Program.Bubble_Sort(array);

            Assert.Equal(new int[] { 2, 3, 4, 5, 8 }, array);
        }

        [Fact]
        public void InsertionSort_Test()
        {
            int[] array = { 9, 7, 5, 11, 12, 2, 14, 3 };

            Program.InsertionSort(array);

            Assert.Equal(new int[] { 2, 3, 5, 7, 9, 11, 12, 14 }, array);
        }

        [Fact]
        public void QuickSort_Test()
        {
            int[] array = { 10, 80, 30, 90, 40, 50, 70 };

            Program.QuickSort(array, 0, array.Length - 1);

            Assert.Equal(new int[] { 10, 30, 40, 50, 70, 80, 90 }, array);
        }

        private int[] GenerateRandomArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Random().Next(0, 10000);
            }
            return array;
        }

        [Fact]
        public void BubbleSort_ShouldCompleteWithinTimeLimit()
        {
            int[] array = GenerateRandomArray(1000);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Program.Bubble_Sort(array);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 500,
                $"BubbleSort took too long: {stopwatch.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void InsertionSort_ShouldCompleteWithinTimeLimit()
        {
            int[] array = GenerateRandomArray(1000);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Program.InsertionSort(array);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 500,
                $"InsertionSort took too long: {stopwatch.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void QuickSort_ShouldCompleteWithinTimeLimit()
        {
            int[] array = GenerateRandomArray(1000);
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            Program.QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();

            Assert.True(stopwatch.ElapsedMilliseconds < 100,
                $"QuickSort took too long: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}