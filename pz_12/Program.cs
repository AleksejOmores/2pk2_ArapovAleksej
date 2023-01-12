namespace pz_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 8, 3, 6, 5, 0, 2, 6, 4, 9 };
            int max1;

            GetMax(arr, out max1);
            Console.WriteLine(max1);
        }
        static void GetMax(int[] arr, out int maxValue)
        {
            maxValue = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }
            }
        }
    }
}