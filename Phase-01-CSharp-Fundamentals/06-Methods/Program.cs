using System;

class Program
{
    static double CalculatePercentage(int total, int maximum)
    {
        return (double)total / maximum * 100;
    }

    static string GetResult(double percentage)
    {
        if (percentage >= 75)
            return "DISTINCTION";
        else if (percentage >= 40)
            return "PASS";
        else
            return "FAIL";
    }

    static void DisplayReport(string name, double percentage, string result)
    {
        Console.WriteLine("Student Result Report");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Percentage: {percentage:F2}%");
        Console.WriteLine($"Result: {result}");
    }

    static void Main()
    {
        string name = "Rohit";
        int total = 480;
        int maximum = 600;

        double percentage = CalculatePercentage(total, maximum);

        string result = GetResult(percentage);

        DisplayReport(name, percentage, result);
    }
}