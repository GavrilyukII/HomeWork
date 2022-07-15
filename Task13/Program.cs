    Console.Clear();
    Console.WriteLine("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num<100)
    {
        Console.WriteLine($"Третьей цифры числа нет");
        return;
    }
    while (num >= 1000) 
    {   
        num = num / 10;
    }
    Console.WriteLine($"Третья цифра числа {num%10}");
            
        