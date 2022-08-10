//1.Задайте массив заполненный случайными положительными трёхзначными числами. 
//2.Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = new int [8];
int rndNum = new Random().Next(100,1000);
int even = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
}
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if(i != array.Length -1)
        Console.Write(", ");
}
Console.Write("]");
for (int i = 0; i < array.Length; i++)
{
    //array[i] = new Random().Next(100,1000);
    if (array[i]%2==0);
    even++;

}
Console.Write($"-> {even}");