
namespace MergeArrays
{

    public class Program
    {
        public static void Main()
        {
            int[] array_1 = { 1, 2, 3, 5, 7 };
            int[] array_2 = { 1, 2, 78, 5, 7 };


            Console.WriteLine(String.Join(",", MergeSortedArrays(array_1, array_2)));
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {
            List<int> list1 = array1.ToList();
            List<int> list2 = array2.ToList();
            List<int> result = list1;

            for (int i = 0; i < array2.Length; i++)
            {
                result.Add(list2[i]);
            }
            result.Sort();
            return result.ToArray();


        }


    }

}