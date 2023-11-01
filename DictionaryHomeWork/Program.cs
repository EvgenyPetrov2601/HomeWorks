string path = "text.txt";
var dictionary  = new Dictionary<string, int>();
foreach (var str in File.ReadAllLines(path))
{
    if (!dictionary.ContainsKey(str))
        dictionary[str] = 1;
    else
        dictionary[str]++;
}
foreach (var pair  in dictionary)
{
    Console.WriteLine($"{pair.Key} = {pair.Value}");
}