namespace kontrolnaya
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            int a = 3;
            int b = 5;

            a = a + b;

            b = a - b;
            a = a - b; 

            Console.WriteLine(a+"\t"+b);
        }

        public static void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        
        public static void Bubble_Sort(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            int x;
            int j;
            for (int i = 1; i < array.Length; i++)
            {
                x = array[i];
                j = i;
                while (j > 0 && array[j - 1] > x)
                {
                    Swap(array, j, j - 1);
                    j -= 1;
                }
                array[j] = x;
            }
        }

        public static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            var pivotIndex = Partition(array, minIndex, maxIndex);
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        public static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }

        public static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }

        public static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
    }
}