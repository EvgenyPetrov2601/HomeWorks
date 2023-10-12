Random r = new Random();
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = r.Next(0,5);
    Console.WriteLine($"array[{i}] = {array[i]}");
}
Console.WriteLine();

Array.Sort(array);
for (int i = 0;i < n; i++)
{
    Console.WriteLine($"array[{i}] = {array[i]}");
}

int count = 0;
var last = array.Max()+1;
for (int i = 1; i < n; i++)
{
    if ((array[i] == array[i - 1]) && (array[i] != last)) 
    {
        count++;
        last = array[i];
    }
}
Console.WriteLine(count);

