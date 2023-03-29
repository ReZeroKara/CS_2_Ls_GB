void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] shelf)
{
    int closet = shelf.Length;
    int position = 0;
    while (position < closet)
    {
        Console.WriteLine(shelf[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);