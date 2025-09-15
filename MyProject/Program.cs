using System;

public class Program

{
    public static void Main(string[] args)
    {


        //login authentication
        Console.Write("username: ");
        string username = Console.ReadLine();

        Console.Write("password: ");
        string password = Console.ReadLine();

        if (username == "correctusername" && password == "correctpassword")
            Console.WriteLine("Login Successful!");
        else
            Console.WriteLine("Invalid credentials!");

        // grade calculator
        Console.Write("Enter the grade: ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
            Console.WriteLine("Grade: A+");
        else if (grade >= 80)
            Console.WriteLine("Grade: A");
        else if (grade >= 70)
            Console.WriteLine("Grade: B");
        else
            Console.WriteLine("Grade: C or below");

        // discount calculation
        Console.Write("Enter amount: ");
        double amount = double.Parse(Console.ReadLine());

        double discount;
        if (amount > 1000)
        {
            discount = amount * 0.10;
        }
        else
        {
            discount = amount * 0.05;
        }
        Console.WriteLine("Discount: " + discount);

        // day of the Week
        Console.Write("Enter day number: ");
        int day = int.Parse(Console.ReadLine());

        string res = day switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid"
        };
        Console.WriteLine(res);

        // traffic light system
        Console.Write("what is the signal color: ");
        string signal = Console.ReadLine().ToLower();

        switch (signal)
        {
            case "red":
                Console.WriteLine("Stop!");
                break;
            case "yellow":
                Console.WriteLine("Get Ready!");
                break;
            case "green":
                Console.WriteLine("Go!");
                break;
            default:
                Console.WriteLine("Invalid signal");
                break;
        }

        // atm withdrawal
        Console.Write("Enter balance: ");
        double balance = double.Parse(Console.ReadLine());

        Console.Write("Enter withdrawal amount: ");
        double withdrawal = double.Parse(Console.ReadLine());

        if (withdrawal <= 0)
            Console.WriteLine("Invalid withdrawal amount");
        else if (withdrawal > balance)
            Console.WriteLine("Insufficient balance");
        else
        {
            balance -= withdrawal;
            Console.WriteLine($"Withdrawal successful! Remaining balance: {balance}");
        }

        // pass or fail Result
        Console.Write("Enter score: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 50)
            Console.WriteLine("Pass");
        else
            Console.WriteLine("Fail");

        // calculator
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter operator:");
        string operation = Console.ReadLine();

        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());

        double calcResult;

        switch (operation)
        {
            case "+":
                calcResult = a + b;
                break;
            case "-":
                calcResult = a - b;
                break;
            case "*":
                calcResult = a * b;
                break;
            case "/":
                if (b == 0)
                {
                    Console.WriteLine("Can't divide by zero");
                    return;
                }
                calcResult = a / b;
                break;
            default:
                Console.WriteLine("Invalid operator");
                return;
        }

        Console.WriteLine("Result: " + calcResult);

        // voting Eligibility
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
            Console.WriteLine("Invalid age");
        else if (age >= 18)
            Console.WriteLine("Eligible to vote");
        else
            Console.WriteLine("Not eligible to vote");

        // employee bonus Calculation
        Console.Write("Enter role (Manager/Developer): ");
        string role = Console.ReadLine();

        Console.Write("Enter salary: ");
        double salary = double.Parse(Console.ReadLine());

        double bonus;

        if (role.ToLower() == "manager")
            bonus = salary > 2500 ? salary * 0.15 : salary * 0.10;
        else if (role.ToLower() == "developer")
            bonus = salary > 2000 ? salary * 0.12 : salary * 0.08;
        else
            bonus = salary * 0.05;

        Console.WriteLine("Bonus: " + bonus);
    }
}
