using System.Collections.Immutable;

namespace MergeArrays
{

    public class Program
    {
        public static Array? sorted_array { get; private set; }

        public static void Main(string[] args)
        {
            //int[] array1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] array2 = new int[] { 3, 2, 5, 4, 6 };
            //MergeSortedArrays(array1, array2);
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            var arrayList = new List<int>();
            arrayList.AddRange(array2);
            arrayList.AddRange(array1);
            arrayList.Sort();
            int[] sortedArrays = arrayList.ToArray();
            return sortedArrays;
        }
    }
    
}