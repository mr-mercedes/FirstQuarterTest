Console.WriteLine("Введите размер массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
string[] array = new string[sizeArray];
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
}
Console.Write("Заданный массив: ");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
string[] newArray = SortArray(array);
Console.Write("Итоговый массив: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}


string[] SortArray(string[] array)
{
    string output = string.Empty;
    string[] newArray = new string[array.Length];
    int maxSize = 3;
    for (int i = 0; i < array.Length; i++)
    {
        output = array[i];
        if (output.Length > maxSize)
            continue;
        newArray[i] = output;
    }
    return newArray;
}