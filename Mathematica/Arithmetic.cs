using System;

namespace Mathematica
{
    /// <summary>
    /// Arithmetic class to do basic arithmetic operations.
    /// </summary>
    static public class Arithmetic
    {
        /// <summary>
        /// Method to add only two integer numbers
        /// </summary>
        /// <param name="firstNum">First number int</param>
        /// <param name="secondNum">Second number int</param>
        /// <returns>The sum of the two numbers</returns>
        public static int AddTwoIntegerNumbers(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        /// <summary>
        /// Method to add only two numbers (integers or decimals)
        /// </summary>
        /// <param name="firstNum">First number double</param>
        /// <param name="secondNum">Second number double</param>
        /// <returns>The sum of the two numbers</returns>
        public static double AddTwoDecimalNumbers(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }

        /// <summary>
        /// Method to add a list of integer numbers
        /// </summary>
        /// <param name="numberList">Array of numbers int</param>
        /// <returns>The sum of all the numbers in the list</returns>
        public static int AddIntegerNumbers(int[] numberList)
        {
            int result = 0;
            foreach (int number in numberList)
            {
                result += number;
            }
            return result;
        }

        /// <summary>
        /// Method to add a list of numbers (integers or decimals)
        /// </summary>
        /// <param name="numberList">Array of numbers double</param>
        /// <returns>The sum of all the numbers in the list</returns>
        public static double AddDecimalNumbers(double[] numberList)
        {
            double result = 0;
            foreach (double number in numberList)
            {
                result += number;
            }
            return result;
        }

        /// <summary>
        /// Method to subtract only two integer numbers
        /// </summary>
        /// <param name="subtrahend">Subtrahend of the operation</param>
        /// <param name="minuend">Minuend of the operation</param>
        /// <returns>The difference of the two numbers</returns>
        public static int SubtractTwoIntegerNumbers(int subtrahend, int minuend)
        {
            return subtrahend - minuend;
        }

        /// <summary>
        /// Method to subtract only two numbers (integer or decimal)
        /// </summary>
        /// <param name="subtrahend">Subtrahend of the operation</param>
        /// <param name="minuend">Minuend of the operation</param>
        /// <returns>The difference of the two numbers</returns>
        public static double SubtractTwoDecimalNumbers(double subtrahend, double minuend)
        {
            return subtrahend - minuend;
        }

        /// <summary>
        /// Method to multiply only two integer numbers
        /// </summary>
        /// <param name="firstNum">First number to multiply</param>
        /// <param name="secondNum">Second number to multiply</param>
        /// <returns>The product of the two numbers</returns>
        public static int MultiplyTwoIntegerNumbers(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        /// <summary>
        /// Method to multiply only two numbers (integer or decimal)
        /// </summary>
        /// <param name="firstNum">First number to multiply</param>
        /// <param name="secondNum">Second number to multiply</param>
        /// <returns>The product of the two numbers</returns>
        public static double MultiplyTwoDecimalNumbers(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }

        /// <summary>
        /// Method to multiply a list of integer numbers
        /// </summary>
        /// <param name="numberList">Array of numbers</param>
        /// <returns>The product of all the numbers in the list</returns>
        public static int MultiplyIntegerNumbers(int[] numberList)
        {
            int result = 1;
            foreach (int number in numberList)
            {
                result *= number;
            }
            return result;
        }

        /// <summary>
        /// Method to multiply a list of numbers (integer or decimal)
        /// </summary>
        /// <param name="numberList">Array of numbers</param>
        /// <returns>The product of all the numbers in the list</returns>
        public static double MultiplyDecimalNumbers(double[] numberList)
        {
            double result = 1;
            foreach (double number in numberList)
            {
                result *= number;
            }
            return result;
        }

        /// <summary>
        /// Method to divide only two integer numbers
        /// </summary>
        /// <param name="dividend">Dividend of the operation</param>
        /// <param name="secondNum">Divisor of the operation</param>
        /// <returns>The division of the two numbers</returns>
        public static int DivideTwoIntegerNumbers(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                new Exception("NaN value");
                return 0;
            }
            return dividend / divisor;
        }

        /// <summary>
        /// Method to divide only two numbers (integer or decimal)
        /// </summary>
        /// <param name="dividend">Dividend of the operation</param>
        /// <param name="secondNum">Divisor of the operation</param>
        /// <returns>The division of the two numbers</returns>
        public static double DivideTwoDecimalNumbers(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                new Exception("NaN value");
                return 0;
            }
            return dividend / divisor;
        }

        /// <summary>
        /// Method to get the absolute value of a number
        /// </summary>
        /// <param name="number">The number argument</param>
        /// <returns>The absolute value of the number</returns>
        public static double GetAbsoluteValue(double number)
        {
            if (number > 0)
            {
                return number;
            }
            else
            {
                return -number;
            }
        }

        /// <summary>
        /// Method to get the sign of a number (either 1, 0 or -1)
        /// </summary>
        /// <param name="number">The number argument</param>
        /// <returns>The sign of the number</returns>
        public static double GetSignOfNumber(double number)
        {
            if (number > 0)
            {
                return 1;
            }
            else if (number < 0)
            {
                return -1;
            }
            return 0;
        }

        /// <summary>
        /// Method to get the factorial of a number
        /// </summary>
        /// <param name="number">The number argument</param>
        /// <returns>The factorial of the number</returns>
        public static double GetFactorial(int number)
        {
            if (number==0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }

        /// <summary>
        /// Method to get the highest of two numbers
        /// </summary>
        /// <param name="firstNum">First number argument</param>
        /// <param name="secondNum">Second number argument</param>
        /// <returns>The max of the two numbers</returns>
        public static double GetMaxFromTwoNumbers(double firstNum, double secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }

        /// <summary>
        /// Method to get the lowest of two numbers
        /// </summary>
        /// <param name="firstNum">First number argument</param>
        /// <param name="secondNum">Second number argument</param>
        /// <returns>The min of the two numbers</returns>
        public static double GetMinFromTwoNumbers(double firstNum, double secondNum)
        {
            if (firstNum < secondNum)
            {
                return firstNum;
            }
            return secondNum;
        }

        /// <summary>
        /// Method to get the floor (truncated) value of a decimal number
        /// </summary>
        /// <param name="number">A double number</param>
        /// <returns>The floored number</returns>
        public static double GetFloorValue(double number)
        {
            return number - (number % 1);
        }

        /// <summary>
        /// Method to get the ceiling value of a decimal number
        /// </summary>
        /// <param name="number">A double number</param>
        /// <returns>The ceiling value of a number</returns>
        public static double GetCeilingValue(double number)
        {
            return number - (number % 1) + 1;
        }

        /// <summary>
        /// Method to get the rounded value of a decimal number
        /// </summary>
        /// <param name="number">A double number</param>
        /// <returns>The rounded number</returns>
        public static double RoundNumber(double number)
        {
            if (number % 1 >= .5)
            {
                return GetCeilingValue(number);
            }
            return GetFloorValue(number);
        }

        /// <summary>
        /// Method to get a power of a number
        /// </summary>
        /// <param name="baseNumber">The base of the power</param>
        /// <param name="exponentNumber">The exponent of the power</param>
        /// <returns>The base elevated to the exponent</returns>
        public static double ElevateToPower(double baseNumber, double exponentNumber)
        {
            double result = 1;
            if (exponentNumber > 0)
            {
                for (int i = 0; i < exponentNumber; i++)
                {
                    result *= baseNumber;
                }
            }
            else if (exponentNumber < 0)
            {
                for (int i = 0; i > exponentNumber; i--)
                {
                    result /= baseNumber;
                }
            }
            return result;
        }

        /// <summary>
        /// Method to get a root of a number
        /// </summary>
        /// <param name="baseNumber">The base of the root</param>
        /// <param name="grade">The grade of the root</param>
        /// <returns>The base with the nth root of the grade</returns>
        public static double GetRootValue(double grade, double baseNumber)
        {
            double guess = baseNumber;
            for (int i = 0; i < 10000; i++)
            {
                double newGuess = (1.0 / grade) * ((grade - 1.0) * guess + baseNumber / ElevateToPower(guess, grade - 1));

                if (GetAbsoluteValue(guess - newGuess) < .001)
                {
                    return newGuess;
                }
                guess = newGuess;
            }
            return guess;
        }

        /// <summary>
        /// Method to get the natural log of a number
        /// </summary>
        /// <param name="argumentNum">A double number</param>
        /// <returns>The natural log of a number</returns>
        public static double GetLogNatural(double argumentNum)
        {
            double result = 0;
            for (int i = 1; i < 10; i++)
            {
                result += ElevateToPower(-1,i-1)*ElevateToPower(argumentNum-1,i)/i;
            }
            return result;
        }

        /// <summary>
        /// Method to get the n-base log of a number
        /// </summary>
        /// <param name="argumentNum">The number to get the log of</param>
        /// <param name="baseNum">The base of the logarith</param>
        /// <returns>The n-base log of the number</returns>
        public static double GetLog(double baseNum, double argumentNum)
        {
            return GetLogNatural(argumentNum) / GetLogNatural(baseNum);
        }
    }

}
