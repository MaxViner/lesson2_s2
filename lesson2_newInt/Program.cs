void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]+", ");
        position++;
    }
}
int IndexOF(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
    {
        if (collection[index] == find)
        {
            position=index;
            break;
        }
        index++;
    }
    return position;
}
int[] kesha = new int[15];

FillArray(kesha);
PrintArray(kesha);
Console.WriteLine();
int pos = IndexOF(kesha,5);
Console.WriteLine(pos);
