namespace Matrix
{
    using System;
    using System.Text;
    [Version(1, 10)]
    public class Matrix<T>
    {
        private T[,] matrixArray;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrixArray = new T[rows, cols];
        }

        public T this[int row, int col]
        {
            get
            {
                T result = this.matrixArray[row, col];
                return result;
            }

            set
            {
                this.matrixArray[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.rows || firstMatrix.cols != secondMatrix.cols)
            {
                throw new Exception("Cannot sum matrices with different sizes!");
            }
            else
            {
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.cols)
            {
                throw new Exception("Cannot substract matrices with different sizes!");
            }
            else
            {
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                    }
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            Matrix<T> result = new Matrix<T>(firstMatrix.rows, firstMatrix.cols);
            if (firstMatrix.rows != secondMatrix.cols)
            {
                throw new Exception("The numbers of columns of the first matrix should match the number of rows of the second matrix in order to multiply them!");
            }
            else
            {
                for (int row = 0; row < result.rows; row++)
                {
                    for (int col = 0; col < result.cols; col++)
                    {
                        for (int firstMatrixCol = 0; firstMatrixCol < firstMatrix.cols; firstMatrixCol++)
                        {
                            result[row, col] += (dynamic)firstMatrix[row, firstMatrixCol] * secondMatrix[firstMatrixCol, col];
                        }
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    result.Append($"{this.matrixArray[row, col],3}");
                    result.Append(" ");
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
