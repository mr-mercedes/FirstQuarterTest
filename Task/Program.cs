string[] array = {"hello", "2", "world", ":-)"};
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
string output = string.Empty;
string[] newArray = new string [array.Length];
for (int i = 0; i < array.Length; i++)
{
    output = array[i];
    if (output.Length > 3)
        continue;
    newArray[i] = output;
}
System.Console.WriteLine();
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}

