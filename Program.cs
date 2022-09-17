string[] array = {"hello", "2", "world", ":-E"};
int counter = 0;
string[] result = new string[0];

foreach(string str in array)
{
    if(str.Length <= 3)
    {
        Array.Resize(ref result, result.Length+1);
        result[counter] = str;
        counter++;
    }
}
Console.WriteLine("[{0}]", string.Join(", ", result));