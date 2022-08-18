// 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
// 2. Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод результата
// 4. Метод реверсии

int[] CreateArrayRndInd (int size, int min, int max)
{
    int[] arr = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min,max + 1);
    }
    return arr;
}

int [] GetSumPosNegElem (int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i]; 
        }
        else
        {
            sumPos += array[i];
        }
    }
    return new int[] {sumNeg, sumPos};
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");
    }
} 

int[] array = CreateArrayRndInd (12, -9, 9);
PrintArray(array);
int[] sumPosNegElem = GetSumPosNegElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumPosNegElem[1]}");
Console.WriteLine($"Сумма отрицательных чисел = {sumPosNegElem[0]}");

void Reverse (int[] array)
{
    int size = array.Legth;
    int index1 = 0;
    int index2 = size-1;
    while (index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}
// Задайте двумерный массив и выведите в консоль
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j == 0) Console.Write("[");
            if(j < array.GetLength(1) - 1) Console.Write($"{array[i,j], 3},");
            else Console.Write($"{array[i,j], 3}");
        }
        Console.WriteLine();
    }
}

int[,] matrixResault = GetMatrix(3, 4);
PrintMatrix (matrixResault);