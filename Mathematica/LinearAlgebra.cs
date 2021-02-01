using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Linear algebra class for generic matrix operations
    /// </summary>
    static public class LinearAlgebra
    {
        /// <summary>
        /// Method to get matrix dimensions
        /// </summary>
        /// <param name="matrix">The matrix</param>
        /// <returns>An int array with the dimensions (row, column)</returns>
        static public int[] checkMatrixDimensions(double[,] matrix)
        {
            int[] matrixDimensions = new int[] {matrix.GetLength(0), matrix.GetLength(1)};
            return matrixDimensions;
        }

        /// <summary>
        /// Method to add matrixes
        /// </summary>
        /// <param name="firstMatrix">First double matrix</param>
        /// <param name="secondMatrix">Second double matrix</param>
        /// <returns>The sum of the matrixes</returns>
        static public double[,] AddTwoMatrixes(double[,] firstMatrix, double[,] secondMatrix)
        {
            int[] firstMatrixDimension = checkMatrixDimensions(firstMatrix);
            int[] secondMatrixDimension = checkMatrixDimensions(secondMatrix);
            double[,] resultMatrix = new double[firstMatrixDimension[0], firstMatrixDimension[1]];
            if (firstMatrixDimension == secondMatrixDimension)
            {
                for (int i = 0; i < firstMatrixDimension[0]; i++)
                {
                    for (int j = 0; j < firstMatrixDimension[1]; j++)
                    {
                        resultMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
                    }
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Method to substract matrixes
        /// </summary>
        /// <param name="firstMatrix">First double matrix</param>
        /// <param name="secondMatrix">Second double matrix</param>
        /// <returns>The difference of the matrixes</returns>
        static public double[,] SubstractTwoMatrixes(double[,] firstMatrix, double[,] secondMatrix)
        {
            int[] firstMatrixDimension = checkMatrixDimensions(firstMatrix);
            int[] secondMatrixDimension = checkMatrixDimensions(secondMatrix);
            double[,] resultMatrix = new double[firstMatrixDimension[0], firstMatrixDimension[1]];
            if (firstMatrixDimension == secondMatrixDimension)
            {
                for (int i = 0; i < firstMatrixDimension[0]; i++)
                {
                    for (int j = 0; j < firstMatrixDimension[1]; j++)
                    {
                        resultMatrix[i, j] = firstMatrix[i, j] - secondMatrix[i, j];
                    }
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Method to multiply a scalar by a matrix
        /// </summary>
        /// <param name="scalar">A double number</param>
        /// <param name="matrix">A double matrix</param>
        /// <returns>The matrix by the scalar</returns>
        static public double[,] MultiplyScalarByMatrix(double scalar, double[,] matrix)
        {
            int[] matrixDimension = checkMatrixDimensions(matrix);
            double[,] resultMatrix = new double[matrixDimension[0], matrixDimension[1]];
            for (int i = 0; i < matrixDimension[0]; i++)
            {
                for (int j = 0; j < matrixDimension[1]; j++)
                {
                    resultMatrix[i, j] = matrix[i, j] * scalar;
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Method to multiply a matrix by a matrix
        /// </summary>
        /// <param name="firstMatrix">First double matrix</param>
        /// <param name="secondMatrix">Second double matrix</param>
        /// <returns>The resultant matrix of the multiplication</returns>
        static public double[,] MultiplyTwoMatrixes(double[,] firstMatrix, double[,] secondMatrix)
        {
            int[] firstMatrixDimension = checkMatrixDimensions(firstMatrix);
            int[] secondMatrixDimension = checkMatrixDimensions(secondMatrix);
            double[,] resultMatrix = new double[firstMatrixDimension[0], secondMatrixDimension[1]];
            if (firstMatrixDimension[1] == secondMatrixDimension[0])
            {
                for (int i = 0; i < firstMatrixDimension[0]; i++)
                {
                    for (int j = 0; j < secondMatrixDimension[1]; j++)
                    {
                        for (int k = 0; k < firstMatrixDimension[1]; k++)
                        {
                            resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                        }
                    }
                }
            }
            return resultMatrix;
        }

        /// <summary>
        /// Method to get the determinant of the matrix
        /// </summary>
        /// <param name="matrix">A double matrix</param>
        /// <returns>The determinant</returns>
        static public double GetDeterminant(double[,] matrix)
        {
            int[] matrixDimension = checkMatrixDimensions(matrix);
            double result = 0;
            if (matrixDimension[0] == matrixDimension[1])
            {
                if (matrixDimension[0]==2)
                {
                    result = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
                    return result;
                }
                
                for (int i = 0; i < matrixDimension[0]; i++)
                {
                    result += Arithmetic.ElevateToPower(-1,i)*matrix[0,i]*GetDeterminant(ConstructSubmatrix(matrix, 0, i));
                }
                return result;
            }
            return 1111110;
        }

        /// <summary>
        /// Method to get a submatrix
        /// </summary>
        /// <param name="matrix">The parent matrix</param>
        /// <param name="excludedRow">Which row to ignore</param>
        /// <param name="excludedColumn">Which column to ignore</param>
        /// <returns>The resultant submatrix</returns>
        static public double[,] ConstructSubmatrix(double[,] matrix, int excludedRow, int excludedColumn)
        {
            int[] matrixDimension = checkMatrixDimensions(matrix);
            double[,] resultMatrix = new double[matrixDimension[0]-1, matrixDimension[1]-1];
            int positionRow = 0, positionColumn = 0;
            for (int i = 0; i < matrixDimension[0]; i++)
            {
                positionColumn = 0;
                if (i == excludedRow)
                {
                    continue;
                }
                for (int j = 0; j < matrixDimension[1]; j++)
                {
                    if (j == excludedColumn)
                    {
                        continue;
                    }
                    resultMatrix[positionRow, positionColumn] = matrix[i, j];
                    positionColumn += 1;
                }
                positionRow += 1;
            }
            return resultMatrix;
        }
    }
}

