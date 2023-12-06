using MatrixControl;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixControl
{
    internal class Matrix
    {
        private int rows;
        private int columns;
        private int[,] matrix;

        public int Rows
        {
            get { return rows; }
        }

        public int Columns
        {
            get { return columns; }
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            matrix = new int[rows, columns];
        }

        public Matrix(int size) : this(size, size) { }

        public void FillRandom()
        {
            var r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = r.Next(10);
            }
        }

        public Matrix Transpose(Matrix matrix)
        {
            var res = new Matrix(matrix.Columns, matrix.Rows);
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    res[j, i] = matrix[i, j];
                }
            }
            return res;
        }
        
        public Matrix ReplaceValues(Matrix matrix)
        {
            for (int i = 0; i<matrix.rows;i++)
            {
                for (int j = 0;j < matrix.columns-i-1; j++)
                {
                    if ((j + i + 1) == matrix.Columns)
                    {
                        matrix[i,i] = matrix[i, j];
                    }
                    else
                    {
                        
                    }
                }
            }
            return matrix;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    sb.Append($"{matrix[i, j],4}");
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public Matrix(string filename)
        {
            string[] lines = File.ReadAllLines(filename);

            string[] size = lines[0].Split(' ');
            int n = int.Parse(size[0]);
            int m = int.Parse(size[1]);
            this.rows = n;
            this.columns = m;
            matrix = new int[n, m];

            for (int i = 1; i < n + 1; i++)
            {
                string[] elements = lines[i].Split(' ');
                for (int j = 0; j < m; j++)
                {
                    matrix[i - 1, j] = int.Parse(elements[j]);
                }
            }
        }


        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a.rows != b.rows || a.columns != b.columns)
                throw new ArgumentException("Размерности матриц должны быть одинаковыми");
            var res = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                    res[i, j] += a[i, j] + b[i, j];
            }
            return res;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a.rows != b.rows || a.columns != b.columns)
                throw new ArgumentException("Размерности матриц должны быть одинаковыми");
            var res = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                    res[i, j] += a[i, j] - b[i, j];
            }
            return res;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.columns != b.rows)
                throw new ArgumentException("Умножаются только матрицы размерностей m x n и n x k");
            var res = new Matrix(a.rows, b.columns);
            for (int i = 0; i < a.rows; i++)
                for (int j = 0; j < b.columns; j++)
                    for (int k = 0; k < b.rows; k++)
                        res[i, j] += a[i, k] * b[k, j];

            return res;
        }
    }
}

