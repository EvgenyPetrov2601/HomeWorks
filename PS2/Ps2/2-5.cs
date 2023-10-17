//double eps = double.Parse(Console.ReadLine());
//Console.WriteLine(Pi(eps));
//Console.WriteLine(Math.PI);
//static double Pi(double eps)
//{
//    double pi = Math.PI;
//    double result = 0;
//    double k = 1;
//    double n = 2;
//    double firstfact = 1;
//    double secondfact = 2;
//    double poweroftwo = 2;
//    while (Math.Abs(pi - (-2 + 2 * result)) > eps)
//    {
//        result += poweroftwo * firstfact * firstfact / secondfact;
//        k++;
//        poweroftwo *= 2;
//        n = n + 2;
//        firstfact *= k;
//        secondfact = secondfact * n * (n - 1);
//    }
//    return -2 + 2 * result;
//}
