static void Main(string[] args)
    {
        Console.WriteLine("Задайте размер массива: ");
        int inputArraySize = Convert.ToInt32(Console.ReadLine());
        string[] inputStrings = ReadInputStrings(inputArraySize);
        string[] result = FindNeededStrings(inputStrings);

        Console.WriteLine("Подходящие строки: " + string.Join(", ", result));
    }

    static string[] ReadInputStrings(int inputArraySize)
    {
        // Запрашиваем элементы массива на ввод
        string[] strings = new string[inputArraySize];
        for (int i = 0; i < inputArraySize; i++)
        {
            Console.Write($"Введите Элемент массива {i + 1}: ");
            strings[i] = Console.ReadLine();
        }
        return strings;
    }

    static string[] FindNeededStrings(string[] inputStrings)
    {
        int suitableCount = 0;

        // Подсчитываем количество подходящих строк
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                suitableCount++;
            }
        }

        string[] suitableStrings = new string[suitableCount];
        int index = 0;

        // Заполняем новый массив подходящими строками
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                suitableStrings[index] = str;
                index++;
            }
        }
        return suitableStrings;
    }
}