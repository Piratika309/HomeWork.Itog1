string[] array = {"терпение", "и", "труд", "всё", "перетрут"};
string[] result = new string[array.Length];

void FillArray(string[] array, string[] result)
{
    int count = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array, result);
PrintArray (result);
