Random r = new Random();
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = r.Next(0, 15);
    Console.WriteLine($"array[{i}] = {array[i]}");
}
string result = "";
for (int i = 0; i < n; i++)
{
    for (int j = i + 1; j < n; j++)
    {
        if (array[j] == array[i])
        {
            result = "Yes";
            break;
        }
    }
    if (result == "Yes")
        break;
    else
        result = "No";
}
Console.WriteLine(result);