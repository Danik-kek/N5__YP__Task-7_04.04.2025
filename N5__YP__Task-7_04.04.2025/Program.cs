namespace N5__YP__Task_7_04._04._2025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите размер массива n: ");
            int n = int.Parse(Console.ReadLine());
            int[] B = new int[n];

            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++) B[i] = int.Parse(Console.ReadLine());

            int countInInterval = 0, countDivBy5 = 0;

            foreach (var num in B)
            {
                countInInterval += num >= -7 && num <= 7 ? 1 : 0;
                countDivBy5 += num % 5 == 0 ? 1 : 0;
            }

            Console.WriteLine($"Количество элементов в интервале [-7; 7]: {countInInterval}");
            Console.WriteLine($"Количество элементов, кратных 5: {countDivBy5}");
        }
    }
}
