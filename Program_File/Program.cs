string[] array = {"hello", "2", "world", ":-)"};

string[] newArray = new string[array.Length];
CreateNewArray(array);
PrintNewArray(newArray);
Console.WriteLine();
void CreateNewArray(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
}
void PrintNewArray(string[] array)
{
    int length = newArray.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write($"{newArray[index]}, ");
        index++;
    }
}