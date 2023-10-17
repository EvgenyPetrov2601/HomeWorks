double down = 0;
double top = 1;
double n = double.Parse(Console.ReadLine());
Console.WriteLine(LeftRectangle(down, top, n));
Console.WriteLine(RightRectangle(down, top, n));
Console.WriteLine(Trapezoid(down, top, n));
Console.WriteLine(Simpson(down, top, n));
static double Func(double x)
{
    return Math.Sin(2 * Math.Sin(2 * x));
}

static double LeftRectangle(double down, double top, double sectionCount)
{
    double result = 0;
    double lenght = (top - down) / sectionCount;
    for (double i = 0; i <= sectionCount - 1; i++)
    {
        result += lenght * Func(down + i * lenght);
    }
    return result;
}

static double RightRectangle(double down, double top, double sectionCount)
{
    double result = 0;
    double lenght = (top - down) / sectionCount;
    for (double i = 1; i <= sectionCount; i++)
    {
        result += lenght * Func(i * lenght);
    }
    return result;
}

static double Trapezoid(double down, double top, double sectionCount)
{
    double result = 0;
    double lenght = (top - down) / sectionCount;
    for (double i = down; i <= top - lenght; i += lenght)
    {
        result += (Func(i) + Func(i + lenght)) / 2 * lenght;
    }
    return result;
}
static double Simpson(double down, double top, double sectionCount) 
{
    double result1 = 0, result2 = 0, result = 0;
    double lenght = (top - down) / sectionCount;
    for (int i = 1; i <= sectionCount; i++)
    {
        if (i % 2 == 0)
            result1 += Func(down + i * lenght);
        else 
            result2 += Func(down + i * lenght); 
    }
    result = lenght / 3 * (Func(down) + Func(top) + 4 * result1 + 2 * result2);
    return result;
}

//static double MonteCarlo(double down, double top, double sectionCount)
//{

//}

