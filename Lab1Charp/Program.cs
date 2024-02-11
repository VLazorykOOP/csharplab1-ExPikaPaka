using System;
using MyMath;

class Program {
    static void Main(string[] args) {
        // Testing task 1
        //task1();

        // Testing task 2
        //task2();

        // Testing task 3
        //task3();

        // Testing task 4
        //task4();

        // Testing task 5
        task5();
    }

    // Task 1 test (Calculates square by providing perimeter)
    private static void task1() {
        Console.WriteLine("|===~        Testing task 1.1        ~===|");
        Console.Write("Enter perimeter to calculate square: ");

        try {
            string? line = Console.ReadLine();
            if (line != null) {
                line = line.Replace('.', ',');
                double p = double.Parse(line);

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
                line = line.Replace('.', ',');
                a = double.Parse(line);
            } else {
                throw new Exception("Couldn't read value a!");
            }

            Console.Write("Enter value b: ");
            line = Console.ReadLine();
            if (line != null) {
                line = line.Replace('.', ',');
                b = double.Parse(line);
            } else {
                throw new Exception("Couldn't read value b!");
            }

            Console.WriteLine("Max value: " + Calculation.Max(a, b));
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }

    // Task 3 test (Define point relation to a shape)
    private static void task3() {
        Console.WriteLine("|===~        Testing task 3.1        ~===|");

        try {
            Console.Write("Enter point coordinate [x, y]: ");

            double x, y; // User point coordinate
            double radius = 12; // Circle radius

            string? input = Console.ReadLine();

            if (input != null) {
                // Reading data
                // Replacing commas with periods to ensure correct parsing
                input = input.Replace('.', ',');

                string[] coordinates = input.Split(' ');
                coordinates = coordinates.Where(val => !string.IsNullOrWhiteSpace(val)).ToArray(); // Removing redundant white spaces

                // Ensuring that exactly two values are provided
                if (coordinates.Length != 2) {
                    Console.WriteLine("Invalid input. Please provide two comma-separated values for x and y coordinates.");
                    return;
                }

                // Parsing the x and y coordinates
                if (!double.TryParse(coordinates[0], out x) || !double.TryParse(coordinates[1], out y)) {
                    Console.WriteLine("Invalid input. Please provide valid numeric values for x and y coordinates.");
                    return;
                }

          

                // Calculating point relation with shape
                int line = MyMath.Calculation.CheckPointLine(x, y); 

                if(line == -1) {
                    Console.WriteLine("Point outside of the shape!");
                    return;
                }
                if (line == 0) {
                    Console.WriteLine("Point on the border!");
                    return;
                }


                // If line == 1
                int circle = MyMath.Calculation.CheckPointInCircle(x, y, radius);

                if (circle == -1) {
                    Console.WriteLine("Point outside of the shape!");
                    return;
                }
                if (circle == 0) {
                    Console.WriteLine("Point on the border!");
                    return;
                }

                // If circle == 1
                Console.WriteLine("Point inside of the shape!");
            } else {
                Console.WriteLine("Nothing provided. Exiting...");
            };
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }

    // Task 4 test (Outputs remaining month count to the end of year)
    private static void task4() {
        Console.WriteLine("|===~        Testing task 4.1        ~===|");
        Console.Write("Enter current month number: ");

        try {
            string? line = Console.ReadLine();
            if (line != null) {
                int num = int.Parse(line);
                int remained = 12 - num;

                if (remained < 1 || remained > 12) { 
                    Console.WriteLine("Wrong month specified! Number must be in [1-12] range");
                    return;
                }
                Console.WriteLine($"To the end of year {remained} months remained");
            } else {
                Console.WriteLine("Nothing provided. Exiting...");
            };
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }

    private static void task5() {
        Console.WriteLine("|===~        Testing task 5.1        ~===|");

        try {
            Console.Write("Enter two integer numbers: ");

            int a, b; // User point coordinate
            string? input = Console.ReadLine();

            if (input != null) {
                // Reading data
                // Replacing commas with periods to ensure correct parsing
                input = input.Replace('.', ',');

                string[] values = input.Split(' ');
                values = values.Where(val => !string.IsNullOrWhiteSpace(val)).ToArray(); // Removing redundant white spaces

                // Ensuring that exactly two values are provided
                if (values.Length != 2) {
                    Console.WriteLine("Invalid input. Please provide two comma-separated values.");
                    return;
                }

                // Parsing the x and y coordinates
                if (!int.TryParse(values[0], out a) || !int.TryParse(values[1], out b)) {
                    Console.WriteLine("Invalid input. Please provide valid integer values ");
                    return;
                }

                Console.WriteLine($"Sum of two values is: {MyMath.Calculation.sum(a, b)}");
            } else {
                Console.WriteLine("Nothing provided. Exiting...");
            };
        } catch (Exception ex) {
            Console.WriteLine(ex.ToString());
        }

        Console.WriteLine();
    }

}
