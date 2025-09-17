using System;

public class Program

{
    public static void Main(string[] args)
    {

        //Output: 1 2 3 4 5 6 7 8 9 10
        Console.WriteLine("printing numbers 1-10:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        //Output: "Sum = 5050"
        Console.WriteLine("sum of numbers 1-100");
        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        Console.WriteLine("Sum = " + sum);
        Console.WriteLine("\n");


        //Output: 1 3 5 7 ... 19
        Console.WriteLine("odd Numbers 1–20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 1)
            {
                Console.WriteLine(i);
                }
        }
        Console.WriteLine("\n");

        // multiplication table for 5
        Console.WriteLine("multiplication Table for n = 5");
        int n = 5;
        for (int i = 1; i <= 9; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
        Console.WriteLine("\n");

        //Output: 10 9 8 ... 1
        Console.WriteLine("reverse printing of numbers 10–1");
        for (int i = 10; i >= 1; i--)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        //factorial for 5
        Console.WriteLine("factorial of 5");
        int factorial = 1;
        for (int i = 1; i <= 5; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial = " + factorial);
        Console.WriteLine("\n");


        //Output: "**********"
        Console.WriteLine("write '*' 10 times");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("\n");

        //Output: "Sum = 55"
        Console.WriteLine("while Loop – Sum Until ≥ 50");
        sum = 0;
        int j = 1;
        while (sum < 50)
        {
            sum += j;
            j++;
        }
        Console.WriteLine("Sum = " + sum + "\n");

        //Output: "Enter password: ... Correct!"
        Console.WriteLine("Do-While Password Check (password = 1234)");
        string password;
        do
        {
            Console.Write("Enter password: ");
            password = Console.ReadLine();
        } while (password != "1234");
        Console.WriteLine("Correct!\n");

        //palindrome
        Console.WriteLine("Palindrome Check");
        int number = 121;
        int original = number;
        int reversed = 0;
        while (number > 0)
        {
            int digit = number % 10;
            reversed = reversed * 10 + digit;
            number /= 10;
        }
        if (original == reversed)
            Console.WriteLine($"{original} is Palindrome\n");
        else
            Console.WriteLine($"{original} is Not Palindrome\n");

        //fibonachi
        Console.WriteLine("Fibonachi Sequence (first 7 numbers)");
        int fibonachiN = 7;
        int a = 0, b = 1;
        for (int i = 0; i < fibonachiN; i++)
        {
            Console.Write(a + " ");
            int temp = a + b;
            a = b;
            b = temp;
        }
        Console.WriteLine();

    }







}
