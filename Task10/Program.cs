    Console.Clear();
    Console.WriteLine("Введите трехзначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if (num < 100 || num >= 1000)
    {
        Console.WriteLine("Введено некорректное число, попробуйте еще раз");
    }
    else
    {
        Console.WriteLine($"Вторая цифра числа: {getSecondDigit(num)}");
    }
    int getSecondDigit(int number)
    {
        return number / 10 % 10;
    }