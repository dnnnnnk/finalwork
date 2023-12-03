string [] array = new string [5];

string[] FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintNewArray(string[] array)
{
    System.Console.WriteLine("новый массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3)
        {
            System.Console.Write($"{array[i]}\t");
        }
    }   
}
PrintNewArray(FillArray());