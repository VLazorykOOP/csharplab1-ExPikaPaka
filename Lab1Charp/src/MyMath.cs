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

        /// <summary>
        /// Checks the position of a point relative to the line y = x.
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        /// <returns>
        ///     0 if the point lies on the line y = x,
        ///     -1 if the point lies in the upper-left half-plane (above the line),
        ///     1 if the point lies in the lower-right half-plane (below the line).
        /// </returns>
        public static int CheckPointLine(double x, double y) {
            double lineY = x; 

            if (Math.Abs(y - lineY) < double.Epsilon) {
                return 0; // Point on the line
            } else if (y > lineY) {
                return -1; // Point in the upper-left plane (above the line)
            } else {
                return 1; // Point in the lower right plane (below the line)
            }
        }

        /// <summary>
        /// Checks if a point lies within a circle.
        /// </summary>
        /// <param name="x">The x-coordinate of the point.</param>
        /// <param name="y">The y-coordinate of the point.</param>
        /// <param name="radius">The radius of the circle.</param>
        /// <returns>
        ///     0 if the point lies on the circle,
        ///     1 if the point lies inside the circle,
        ///     -1 if the point lies outside the circle.
        /// </returns>
        public static int CheckPointInCircle(double x, double y, double radius) {
            // Calculate the distance from the point to the center of the circle
            double distanceSquared = x * x + y * y;
            double radiusSquared = radius * radius;

            // Check if the point lies on the circle
            if (Math.Abs(distanceSquared - radiusSquared) < double.Epsilon) {
                return 0; // Point lies on the circle
            } else if (distanceSquared < radiusSquared) {
                return 1; // Point lies inside the circle
            } else {
                return -1; // Point lies outside the circle
            }
        }

        /// <summary>
        /// Calculates the sum of two integers.
        /// </summary>
        /// <param name="a">The first integer.</param>
        /// <param name="b">The second integer.</param>
        /// <returns>The sum of the two integers.</returns>
        public static int sum(int a, int b) {
            return a + b;
        }
    }
}
