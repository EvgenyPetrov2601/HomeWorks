int number;
number = int.Parse(Console.ReadLine());
int i = 1;
while (i <= number)
{
    if (number == i)
    {
        Console.WriteLine("Является степенью");
        break;
    }
    else
        i *= 3;
}
if (i > number)
    Console.WriteLine("Не является степенью");
