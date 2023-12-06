using MatrixControl;

namespace ControlWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matr = new Matrix("Matrix.txt");
            Console.WriteLine(matr);
            matr.ReplaceValues(matr);
            Console.WriteLine(matr);

        }
    }
}