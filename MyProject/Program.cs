using System;

public class Program
{
    public static void Main(string[] args)
    {
        //Pyramid
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        //Even Numbers 
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int start = Math.Min(a, b);
        int end = Math.Max(a, b);

        Console.WriteLine("Even numbers in range:");
        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();

        //Calculator
        while (true)
        {
            try
            {
                Console.Write("Enter first number or X to exit: ");
                string input = Console.ReadLine();
                if (input.ToUpper() == "X")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                int num1 = int.Parse(input);

                Console.Write("Enter operator (+, -, *): ");
                string op = Console.ReadLine();

                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());

                int result = 0;
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    default:
                        throw new ArgumentException("Only +, -, * operators are allowed!");
                }

                Console.WriteLine("Result: " + result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number format");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
            }
        }
    }
}
