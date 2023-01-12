namespace pz_7;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Элементов в массиве: ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[a];
        Random rnd = new Random();

        for (int i = 0; i < nums.Length; ++i)
        {
            nums[i] = rnd.Next(-50, 49);
            Console.Write(nums[i] + " ");
        }

        int min = nums[0];

        for (int i = 0; i < nums.Length; ++i)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }

        Console.WriteLine("\nМинимальный элемент в массиве = " + min);

        int sum = 0;
        foreach (int x in nums)
        {
            if (x < 0)
            {
                sum += x;
            }
        }
        Console.WriteLine("Сумма отрицательных элементов массива = " + sum);

        if (sum > -100)
        {
            sum += min;
            Console.WriteLine("Сумма отрицательных элементов массива при недостакте = " + sum);
        }
    }
}
}
