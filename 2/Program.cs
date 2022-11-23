int[] FillArray(int size)
{
    int[] array = new int[size];
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 10);
        index++;
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int ind = 0;
    while (ind < count)
    {
        Console.Write(col[ind]);
        ind++;
    }
    System.Console.WriteLine();
}


int[] Reverse(int[] array)
{
    int i = 0;
    int[] newArray = new int[array.Length];

    while (i <= (array.Length - 1))
    {
        newArray[i] = array[(array.Length - 1) - i];
        i++;
    }
return newArray;
}
int[] array = FillArray(10);
PrintArray(array);
array = Reverse(array);
PrintArray(array);