//double eps = double.Parse(Console.ReadLine());
//Console.WriteLine(Catalan(eps));
//static double Catalan(double eps)
//{
//    double Cat = 0.915965594177219;
//    double x = 1;
//    double result = 0;
//    long n = 0;
//    while (Math.Abs(result - Cat) > eps)
//    {
//        result += x / ((2 * n + 1) * (2 * n + 1));
//        x *= -1;
//        n += 1;
//    }
//    Console.WriteLine($"Достигается на {n} шаге");
//    return result;
//}
