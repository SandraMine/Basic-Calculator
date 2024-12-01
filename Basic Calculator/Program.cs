namespace Basic_Calculator
{
    internal class Program
    {
class Calculator
        {
            static void Main()
            {
                while (true)
                {
                    Console.WriteLine("Enter the first number (or type 'exit' to quit): ");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() == "exit") break;

                    if (!double.TryParse(input1, out double num1))
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value and number.");
                        continue;
                    }

                    Console.WriteLine("Enter the second number: ");
                    string input2 = Console.ReadLine();
                    if (!double.TryParse(input2, out double num2))
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                        continue;
                    }

                    Console.WriteLine("Enter an operation (+, -, *, /): ");
                    string operation = Console.ReadLine();

                    double result;
                    switch (operation)
                    {
                        case "+":
                            result = Add(num1, num2);
                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                            break;
                        case "-":
                            result = Subtract(num1, num2);
                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                            break;
                        case "*":
                            result = Multiply(num1, num2);
                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                            break;
                        case "/":
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: Division by zero is not allowed.");
                            }
                            else
                            {
                                result = Divide(num1, num2);
                                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static double Add(double a, double b) => a + b;

            static double Subtract(double a, double b) => a - b;

            static double Multiply(double a, double b) => a * b;

            static double Divide(double a, double b) => a / b;
        }

    }
}

