// Math namespace for some functions
namespace MyMath {

    /// <summary>
    /// Provides mathematical calculations.
    /// </summary>
    public class Calculation {

        /// <summary>
        /// Calculates the square of a number given its perimeter.
        /// </summary>
        /// <param name="perimeter">The perimeter of the square.</param>
        /// <returns>The area of the square.</returns>
        public static double Square(double perimeter) {
            return perimeter * perimeter;
        }

        /// <summary>
        /// Returns the maximum of two numbers.
        /// </summary>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The greater of the two numbers.</returns>
        public static double Max(double a, double b) {
            return a > b ? a : b;
        }
    }
}
