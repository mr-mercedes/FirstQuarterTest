string[] array = {Console.ReadLine()};
string output = string.Empty;
for (int i = 0; i < array.Length; i++)
{
    output = array[i];
}
int countNumbers = 1;
for (int i = 0; i < output.Length; i++)
{
    if (output[i] == ',')
        countNumbers++;
}
string[] newArray = new string [countNumbers];
int newArrayIndex = 0;
for (int i = 0; i < output.Length; i++)
{
    string subString = string.Empty;
    while (output[i] != ',')
    {
        if (i >= output.Length - 1)
            break;
        subString += output[i];
        i++;
        if (subString == "" || subString == " ")
            continue;
    }
    newArray[newArrayIndex] = subString;
    newArrayIndex++;
    
}
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}
