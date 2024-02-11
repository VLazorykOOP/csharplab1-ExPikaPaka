using System;
using MyMath;
using System.Globalization; // Used for '.' as delimiter in floating-point operations
class Program {
    static void Main(string[] args) {
        // Testing task 1
        task1();

        // Testing task 2
        task2();
    }

    // Task 1 test (Calculates square by providing perimeter)
    private static void task1() {
        Console.WriteLine("|===~        Testing task 1.1        ~===|");
        Console.Write("Enter perimeter to calculate square: ");

        try {
            string? line = Console.ReadLine();
            if (line != null) {
                double p = double.Parse(line, CultureInfo.InvariantCulture);

                double square = MyMath.Calculation.Square(p);
                Console.WriteLine("Calculated square: " + square.ToString(".000"));
            }
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }

    // Task 2 test (Calculates max value)
    private static void task2() {
        Console.WriteLine("|===~        Testing task 2.1        ~===|");

        try {
            double a, b;

            Console.Write("Enter value a: ");
            string? line = Console.ReadLine();
            if (line != null) {
                a = double.Parse(line, CultureInfo.InvariantCulture);
            } else {
                throw new Exception("Couldn't read value a!");
            }

            Console.Write("Enter value b: ");
            line = Console.ReadLine();
            if (line != null) {
                b = double.Parse(line, CultureInfo.InvariantCulture);
            } else {
                throw new Exception("Couldn't read value b!");
            }

            Console.WriteLine("Max value: " + Calculation.Max(a, b));
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }
}
