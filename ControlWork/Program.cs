
Console.Clear();
int CountDigitThree (string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            count++;
        } 
    }
    return count;
}

string[] CreateStringLess(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
   for (int i = 0; i < array.Length; i++)
    {
       if(i == 0) Console.Write("[");
       if(i < array.Length - 1) Console.Write("\"" + array[i] + "\",");
       else Console.Write("\"" + array[i] + "\"]");
   }
} 

string[] array1 = {"hello", "3", "world", ")6GG", "y3y", "K)k45"};
int count = CountDigitThree (array1);
string[] array2 = CreateStringLess(array1, count);
