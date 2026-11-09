/*
===============================================================================
PROBLEM STATEMENT: Student Performance Report Generator
===============================================================================

Build a console application that accepts student academic and assessment 
information and generates a performance report.

REQUIREMENTS:
Your program must store:
- Student name
- Roll number
- Marks in 5 subjects (out of 100)
- Attendance percentage
- Previous CGPA
- Number of active backlogs

PROCESSING REQUIREMENTS:
1. Calculate total marks.
2. Calculate percentage.
3. Calculate average marks.
4. Calculate the highest and lowest subject marks.
5. Determine the grade based on percentage:
   - 90% – 100%   : A+
   - 80% – 89.99% : A
   - 70% – 79.99% : B
   - 60% – 69.99% : C
   - 50% – 59.99% : D
   - Below 50%    : F
6. Determine academic eligibility:
   - Attendance >= 75%
   - No active backlogs
   - Percentage >= 60%
7. Generate a formatted report using string interpolation.

SAMPLE OUTPUT:
========== STUDENT PERFORMANCE REPORT ==========

Name              : Rohit Rathod
Roll Number       : 23ECE101
Total Marks       : 425 / 500
Percentage        : 85.00%
Average           : 85.00
Highest Marks     : 95
Lowest Marks      : 70
Grade             : A
Attendance        : 82%
Active Backlogs   : 0
Placement Eligible: YES

===============================================

CONSTRAINTS:
- Use appropriate C# data types.
- Use 'const' wherever applicable.
- Use 'decimal' for percentage calculations if appropriate.
- Use string interpolation for output.
- Do NOT use arrays, loops, or custom methods.
- Use only variables, operators, and basic expressions.

BONUS CHALLENGE:
- Calculate the marks required in the next assessment to achieve 
  an overall target percentage of 90%.
===============================================================================
*/

using System;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter Student Name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter Roll Number: ");
        string rollNumber = Console.ReadLine();
        Console.WriteLine("Enter Marks in 5 Subjects (out of 100): ");
        Console.Write("Subject 1: ");
        int subject1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 2: ");
        int subject2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 3: ");
        int subject3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 4: ");
        int subject4 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Subject 5: ");
        int subject5 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Attendance Percentage: ");
        decimal attendance = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Previous CGPA: ");
        decimal previousCgpa = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Enter Number of Active Backlogs: ");
        int activeBacklogs = Convert.ToInt32(Console.ReadLine());

        // Calculate total marks
        int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
        // Calculate percentage
        decimal percentage = (totalMarks / 500m) * 100;
        // Calculate average marks
        decimal averageMarks = totalMarks / 5m;
        // Determine highest and lowest marks
        int highestMarks = Math.Max(Math.Max(subject1, subject2), Math.Max(subject3, Math.Max(subject4, subject5)));
        int lowestMarks = Math.Min(Math.Min(subject1, subject2), Math.Min(subject3, Math.Min(subject4, subject5)));
        // Determine grade based on percentage
        string grade;
        if (percentage >= 90)
        {
            grade = "A+";
        }
        else if (percentage >= 80)
        {
            grade = "A";
        }
        else if (percentage >= 70)
        {
            grade = "B";
        }
        else if (percentage >= 60)
        {
            grade = "C";
        }
        else if (percentage >= 50)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        // Determine academic eligibility
        bool isEligible = attendance >= 75 && activeBacklogs == 0 && percentage >= 60;

        // Generate formatted report
        Console.WriteLine("\n========== STUDENT PERFORMANCE REPORT ==========");
        Console.WriteLine($"Name              : {name}");
        Console.WriteLine($"Roll Number       : {rollNumber}");
        Console.WriteLine($"Total Marks       : {totalMarks} / 500");
        Console.WriteLine($"Percentage        : {percentage:F2}%");
        Console.WriteLine($"Average           : {averageMarks:F2}");
        Console.WriteLine($"Highest Marks     : {highestMarks}");
        Console.WriteLine($"Lowest Marks      : {lowestMarks}");
        Console.WriteLine($"Grade             : {grade}");
        Console.WriteLine($"Attendance        : {attendance}%");
        Console.WriteLine($"Active Backlogs   : {activeBacklogs}");
        
        Console.WriteLine($"Placement Eligible: {(isEligible ? "YES" : "NO")}");
        Console.WriteLine("===============================================");
    }
}