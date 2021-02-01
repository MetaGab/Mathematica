using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematica
{
    /// <summary>
    /// Vectorial class for generic vector operations
    /// </summary>
    static public class Vectorial
    {

        /// <summary>
        /// Method to check if both vectors have the same number of components
        /// </summary>
        /// <param name="firstVector">First double vector</param>
        /// <param name="secondVector">Second double vector</param>
        /// <returns>True if it has the same, false if not</returns>
        static public bool CheckEqualGrade(double[] firstVector, double[] secondVector)
        {
            return firstVector.Length == secondVector.Length;
        }

        /// <summary>
        /// Method to add two vectors
        /// </summary>
        /// <param name="firstVector">First double vector</param>
        /// <param name="secondVector">Second double vector</param>
        /// <returns>The sum of the vectors</returns>
        static public double[] AddTwoVectors(double[] firstVector, double[] secondVector)
        {
            double[] resultVector = new double[firstVector.Length];
            if (CheckEqualGrade(firstVector,secondVector))
            {
                for (int i = 0; i < resultVector.Length; i++)
                {
                    resultVector[i] = firstVector[i] + secondVector[i];
                }
            }
            return resultVector;
        }

        /// <summary>
        /// Method to substract two vectors
        /// </summary>
        /// <param name="firstVector">First double vector</param>
        /// <param name="secondVector">Second double vector</param>
        /// <returns>The difference of the vectors</returns>
        static public double[] SubstractTwoVectors(double[] firstVector, double[] secondVector)
        {
            double[] resultVector = new double[firstVector.Length];
            if (CheckEqualGrade(firstVector, secondVector))
            {
                for (int i = 0; i < resultVector.Length; i++)
                {
                    resultVector[i] = firstVector[i] - secondVector[i];
                }
            }
            return resultVector;
        }

        /// <summary>
        /// Method to add a list of vectors
        /// </summary>
        /// <param name="vectorList">An array of vectors</param>
        /// <returns>The resultant vector of all the additions</returns>
        static public double[] AddVectors(double[][] vectorList)
        {
            int numberOfVectors = vectorList.Length;
            double[] resultVector = new double[vectorList[0].Length];
            for (int i = 0; i < numberOfVectors; i++)
            {
                if (CheckEqualGrade(vectorList[i], resultVector))
                {
                    for (int j = 0; i < resultVector.Length; i++)
                    {
                        resultVector[j] += vectorList[i][j];
                    }
                }
                else
                {
                    break;
                }
            }
            return resultVector;
        }

        /// <summary>
        /// Method to multiply a scalar by a vector
        /// </summary>
        /// <param name="scalar">A double number</param>
        /// <param name="vector">A double vector</param>
        /// <returns>The product of the scalar by the vector</returns>
        static public double[] MultiplyScalarByVector(double scalar, double[] vector)
        {
            double[] resultVector = new double[vector.Length];
            for (int i = 0; i < resultVector.Length; i++)
            {
                resultVector[i] = scalar * vector[i];
            }
            return resultVector;
        }

        /// <summary>
        /// Method to get the magnitude of a vector
        /// </summary>
        /// <param name="vector">A double vector</param>
        /// <returns>The magnitude of the vector as a double</returns>
        static public double GetMagnitude(double[] vector)
        {
            double magnitude = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                magnitude += Arithmetic.ElevateToPower(vector[i], 2);
            }
            return Arithmetic.GetRootValue(2, magnitude);
        }

        /// <summary>
        /// Method to get the direction of the vector as a unit vector
        /// </summary>
        /// <param name="vector">A double vector</param>
        /// <returns>A vector with a magnitude of 1 in the same direction</returns>
        static public double[] GetUnitVector(double[] vector)
        {
            double[] resultVector = new double[vector.Length];
            double magnitude = GetMagnitude(vector);
            for (int i = 0; i < resultVector.Length; i++)
            {
                resultVector[i] = vector[i]/magnitude;
            }
            return resultVector;
        }

        /// <summary>
        /// Method to get the dot product of two vectors
        /// </summary>
        /// <param name="firstVector">First double vector</param>
        /// <param name="secondVector">Second double vector</param>
        /// <returns>The dot product expressed as a double number</returns>
        static public double GetDotProduct(double[] firstVector, double[] secondVector)
        {
            double result = 0;
            if (CheckEqualGrade(firstVector, secondVector))
            {
                for (int i = 0; i< firstVector.Length; i++)
                {
                    result += firstVector[i] * secondVector[i];
                }
            }
            return result;
        }

        /// <summary>
        /// Method to get the cross product of two vectors of three dimensions
        /// </summary>
        /// <param name="firstVector">First double vector</param>
        /// <param name="secondVector">Second double vector</param>
        /// <returns>The cross product expressed as another vector of three dimensions</returns>
        static public double[] GetCrossProduct(double[] firstVector, double[] secondVector)
        {
            double[] resultVector = new double[firstVector.Length];
            if (CheckEqualGrade(firstVector, secondVector) && firstVector.Length==3)
            {
                resultVector[0] = firstVector[1] * secondVector[2] - firstVector[2] * secondVector[1];
                resultVector[1] = firstVector[2] * secondVector[0] - firstVector[0] * secondVector[2];
                resultVector[2] = firstVector[0] * secondVector[1] - firstVector[1] * secondVector[0];
            }
            return resultVector;
        }
    }
}
