using System;

namespace CalculatorLibrary
{
    /// <summary>
    /// A class containing simple functions for a calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Adds the two values and returns the total. 
        /// </summary>
        /// <param name="firstValue">first value to be added</param>
        /// <param name="secondValue">second value to be added</param>
        /// <returns>the two values added together</returns>
        public static double Add(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }

        /// <summary>
        /// Subtracts the two values and returns the total.
        /// </summary>
        /// <param name="firstValue">first value to be subtracted</param>
        /// <param name="secondValue">second value to be subtracted</param>
        /// <returns>the sum of the subtracted values</returns>
        public static double Subtract(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }

        /// <summary>
        /// Multiplies the two values and returns the total.
        /// </summary>
        /// <param name="firstValue">first value to be multiplied</param>
        /// <param name="secondValue">second value to be multiplied</param>
        /// <returns>the sum of the two values multiplied</returns>
        public static double Multiply(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }

        /// <summary>
        /// Divides the two values and returns the total. 
        /// </summary>
        /// <param name="firstValue">first value to be divided</param>
        /// <param name="secondValue">second value to be divided</param>
        /// <returns>the sum of the two values divided</returns>
        public static double Divide(double firstValue, double secondValue)
        {
            return firstValue / secondValue;
        }
    }
}
