var list = new List<char>();
var str = Console.ReadLine();
var strSecond = str.ToLower();
foreach (var item in strSecond)
{
    if (item != ' ')
    {
        list.Add(item);
    }
}
static string GetPalin(List<char> list, int first, int last)
{
    if (first >= last)
    {
        return "Палиндром";
    }
    if (list[first] == list[last])
    {
        return GetPalin(list, first + 1, last - 1);
    }
    return "Не палиндром";
}
Console.WriteLine(GetPalin(list, 0, list.Count - 1));
