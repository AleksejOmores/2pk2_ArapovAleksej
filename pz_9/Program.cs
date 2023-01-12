namespace pz_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sum = new char[9];
            char[][] arr = new char[9][];
            char[] arr2 = new char[9];
            char[] arr3 = new char[9];

            Random rnd = new Random();
            int value = rnd.Next(10, 35);
            arr[0] = new char[value];
            arr[1] = new char[value];
            arr[2] = new char[value];
            arr[3] = new char[value];
            arr[4] = new char[value];
            arr[5] = new char[value];
            arr[6] = new char[value];
            arr[7] = new char[value];
            arr[8] = new char[value];
            Console.WriteLine("Задание 2");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < arr[i].GetLength(0); ++j)
                {
                    int num = rnd.Next(0, 100);
                    arr[i][j] = Convert.ToChar(num);
                    sum[i] += Convert.ToChar(num);
                    Console.Write($"{arr[i][j]} ");
                    if (num > max)
                    {
                        max = num;
                        arr3[i] = Convert.ToChar(num);
                    }
                    if (j < arr[i].GetLength(0))
                    {
                        arr2[i] = Convert.ToChar(num);
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 3");

            Console.WriteLine($"Последние элементы: {arr2[0]} {arr2[1]} {arr2[2]} {arr2[3]} {arr2[4]} {arr2[5]} {arr2[6]} {arr2[7]} {arr2[8]}");

            Console.WriteLine("Задание 4");

            Console.WriteLine($"Максимальные элементы: {arr3[0]} {arr3[1]} {arr3[2]} {arr3[4]} {arr3[5]} {arr3[6]} {arr3[7]} {arr3[8]}");

            Console.WriteLine("Задание 5");

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[0].GetLength(0); j++)
                {
                    if (arr[i][j] == arr3[i])
                    {
                        arr[i][j] = arr[i][0];
                    }
                    if (j == 0)
                    {
                        Console.Write($"{arr3[i]} ");
                    }
                    else
                    {
                        Console.Write($"{arr[i][j]} ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задние 6");
            Array.Reverse(arr[0]);
            Array.Reverse(arr[1]);
            Array.Reverse(arr[2]);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].GetLength(0); j++)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}