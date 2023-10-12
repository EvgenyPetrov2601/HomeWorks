Random r = new Random();
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
    array[i] = r.Next(0, 10);
    Console.WriteLine($"array[{i}] = {array[i]}");
}
Array.Sort(array);
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"array[{i}] = {array[i]}");
}
int count = 1;
for (int i = 1;i < n; i++)
{
    if (array[i] !=array[i - 1])
        count++;
}
Console.WriteLine(count);


