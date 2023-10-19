Random random = new Random();
int matrLenght = int.Parse(Console.ReadLine());
int matrHeight = int.Parse(Console.ReadLine());
int[,] matr = new int[matrHeight, matrLenght];
for (int i = 0; i < matrHeight; i++)
{
    for (int j = 0; j < matrLenght; j++)
    {
        matr[i, j] = random.Next(0, 2);
    }
}

for (int i = 0; i < matrHeight; i++)
{
    for (int j = 0; j < matrLenght; j++)
    {
        Console.Write($"{matr[i, j],3} ");
    }
    Console.WriteLine();
}
string result = "Симметричная матрица";

if (matrLenght != matrHeight)
{
    Console.WriteLine("Неверная матрица");
}
else
{
    for (int i = 0; i < matrHeight; i++)
    {
        for (int j = i; j < matrLenght; j++)
        {
            if (matr[i, j] != matr[j, i])
                result = "Не семметричная матрица";
        }
    }
    Console.WriteLine(result);
}

