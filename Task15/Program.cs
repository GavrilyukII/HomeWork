Console.Clear();
    Console.WriteLine("Введите цифру, обозначающую день недели: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num < 1 || num > 7)
    {
        Console.WriteLine("Введена некорректная цифра, попробуйте еще раз");
    }
    else if (num == 6 || num == 7)
    {
        Console.WriteLine($"{num} --> Да");
    }
    else
    {
        Console.WriteLine($"{num} --> Нет");
    }