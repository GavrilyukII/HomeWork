Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num / 10; 
int res = a % 10; 
    if (num < 100 || num >= 1000)
{
    Console.WriteLine ("Введено некорректное число, попробуйте еще раз");
}
    else
{
    Console.WriteLine ($"Вторая цифра числа: {res}");    
}

