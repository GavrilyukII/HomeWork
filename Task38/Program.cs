//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInd (int size, double min, double max)
{
    double[] arr = new double [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(GetRandomNumber (min, max), 2);
    }
    return arr;
}

double GetRandomNumber(double minimum, double maximum)
            {
                Random random = new Random();
                return random.NextDouble()* (maximum - minimum) + minimum;
            }

double [] GetMaxMinNum (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
        max = array[i];
        }
        if (array[i] < min)
        {
        min = array[i];
        }
    }
return new double[] {max, min};
}

double GetDiffMaxMin (double max, double min)
{
    double diff = max - min;
    return diff;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i] + "] ");
    }
}

Console.Clear();
double[] array = CreateArrayRndInd (15, 1, 99);
PrintArray (array);
double[] MinMax = GetMaxMinNum (array);
double diff = Math.Round (GetDiffMaxMin (MinMax[0], MinMax[1]),2);
Console.Write($"-> {diff}");