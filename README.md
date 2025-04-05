потеряный 8 из 5yp

static void Main()
    {
        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());
        int[] C = new int[m];

        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < m; i++) C[i] = int.Parse(Console.ReadLine());

        int sum3 = 0, cnt3 = 0; // Для среднего арифметического кратных 3
        int max9 = int.MinValue; // Для максимального элемента, кратного 9

        foreach (var x in C)
        {
            if (x % 3 == 0) { sum3 += x; cnt3++; } // Подсчет для кратных 3
            if (x % 9 == 0 && x > max9) max9 = x; // Поиск максимального для кратных 9
        }

        double avg3 = cnt3 > 0 ? (double)sum3 / cnt3 : 0;

        Console.WriteLine($"Среднее кратных 3: {avg3:F2}");
        Console.WriteLine(max9 != int.MinValue ? $"Максимальное кратное 9: {max9}" : "Нет кратных 9");
    }
    
