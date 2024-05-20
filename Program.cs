string[] array_in = new string[6] {"2257", "5351", "mix", "long", "one","ggg"};
string[] array_out = new string[array_in.Length];

void GetShortStrings(string[] array_in, string[] array_out)
{
    int counter = 0;
    for (int i = 0; i < array_in.Length; i++)
    {
    if(array_in[i].Length <= 3)
        {
        array_out[counter] = array_in[i];
        counter++;
        }
    }
}   
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetShortStrings(array_in, array_out);
PrintArray(array_out);