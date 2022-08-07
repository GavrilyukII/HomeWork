//Задача 29: Напишите программу, которая задаёт массив из 8 элементов, заполненный
//псевдослучайными числами и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int [8];
int rndNum = new Random().Next(0,100);
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,100);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if(i != array.Length -1)
        Console.Write(", ");
}
Console.Write("]");