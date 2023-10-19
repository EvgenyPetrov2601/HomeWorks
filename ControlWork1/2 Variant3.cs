int arrayLenght = int.Parse(Console.ReadLine());
var array = new int[arrayLenght];
for (int i = 0; i < arrayLenght; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}
double minusCount = 0;
int minusSum = 0;

for (int i = 0; i < arrayLenght; i++)
{
    if (array[i] < 0)
    {
        minusCount++;
        minusSum += array[i];
    }
}

double result = minusSum / minusCount;
Console.WriteLine(result);