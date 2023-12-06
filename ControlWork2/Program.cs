using MatrixControl;

namespace ControlWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matr = new Matrix("Matrix.txt");
            Console.WriteLine(matr);
            var matr1 = new Matrix(matr);
            Console.WriteLine(matr1);

        }
    }
}