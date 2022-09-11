
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

string[] array1 = {"hello", "3", "world", ")6GG", "y3y", "K)k45"};
int count = CountDigitThree (array1);

