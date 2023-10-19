//1
var array = new int[] { -3, 7, 27, 10, -9, 7, -7 };
int plusnumber = 0;
int minusnumber = 0;
int countplus = 0;
int countminus = 0;
int plusplace = 0;
int minusplace = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i] > 0)
    {
        countplus++;
        if (countplus == 2)
        {
            plusnumber = array[i];
            plusplace = i;
        }
    }
Console.WriteLine($"Второе положительное число слева {plusnumber}");
Console.WriteLine($"Номер положительного числа {plusplace} ");
for (int i = array.Length - 1; i >= 0; i--)
{
    if (array[i] < 0)
    {
        countminus++;
        if (countminus == 2)
        {
            minusnumber = array[i];
            minusplace = i;
        }
    }
}
Console.WriteLine($"Второе отрицательное число справа {minusnumber}");
Console.WriteLine($"Номер отрицательного числа {minusplace}");
(array[plusplace], array[minusplace]) = (array[minusplace], array[plusplace]);
for (int i = 0; i <= array.Length; i++)
    Console.WriteLine(array[i]);