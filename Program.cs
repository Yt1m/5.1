Console.WriteLine("Введите строку");
char[] mas = Console.ReadLine().ToCharArray();
        int b = mas.Length / 2;
        for (int i = 0; i < b; i++)
        {
            if (mas[i] == ':')
            {
                mas[i] = '.';
            }
        }
        for (int i = b; i < mas.Length; i++)
        {
            if (mas[i] == '!')
            {
                mas[i] = '.';
            }
        }
        Console.WriteLine(new string(mas));