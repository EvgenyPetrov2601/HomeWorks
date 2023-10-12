// Задание 1.15
string ticket = Console.ReadLine();
int sum1 = 0;
int sum2 = 0;
if (ticket.Length != 6)
    Console.WriteLine("Неправильный формат билета");
if (ticket.Length == 6)
{
    for (int i = 0; i < ticket.Length; i++)
    {
        if (i % 2 == 0)
            sum1 += int.Parse(Convert.ToString(ticket[i]));
        else
            sum2 += int.Parse(Convert.ToString(ticket[i]));
    }
    if (sum1 == sum2)
        Console.WriteLine("Счастливый");
    else
        Console.WriteLine("Не счастливый");
}



// Задание 2.6
int sum = 0;
for (int i = 0; i < 1000; i++)
{
    if ((i % 3 == 0) || (i % 5 == 0))
        sum += i;
}
Console.WriteLine(sum);



// Задание 4.8
int sumnum = 0;
for (int a = 1; a < 10; a++)
{
    for (int b = 0; b < 10; b++)
    {
        for (int c = 0; c < 10; c++)
        {
            for (int d = 0; d < 10; d++)
            {
                if (Math.Pow(a, 4) + Math.Pow(b, 4) + Math.Pow(c, 4) + Math.Pow(d, 4) == int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString()))
                //if (a*a*a*a+b*b*b*b+c*c*c*c+d*d*d*d == int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString()))
                {
                    sumnum += int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString());
                    Console.WriteLine(int.Parse(a.ToString() + b.ToString() + c.ToString() + d.ToString()));
                }
            }
        }
    }
}
Console.WriteLine(sumnum);



// Задание 3.17
int n = int.Parse(Console.ReadLine());
Random r = new Random();
static bool SimpleNumber(int number)
{
    if (number > 1)
    {
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
    return false;
}
int[] array = new int[n];
for (int i = 0; i < array.Length; i++)
{
    array[i] = r.Next(-1000000000, 1000000001);
    Console.WriteLine($"{i + 1} число = {array[i]}");
}
int count = 0;
foreach (int num in array)
{
    if (SimpleNumber(num))
    {
        count++;
    }
}
Console.WriteLine($"Количество простых чисел = {count}");