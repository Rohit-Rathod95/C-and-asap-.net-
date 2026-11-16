/*
================================================================================
PROBLEM STATEMENT:
Build a console application that manages student subject marks and generates a 
result report.

REQUIREMENTS:
1.  Store student name and roll number.
2.  Accept marks for 6 subjects using an array.
3.  Display all subject marks.
4.  Calculate total marks.
5.  Calculate percentage.
6.  Find highest and lowest marks.
7.  Count failed subjects (marks below 40).
8.  Display pass/fail status.
9.  Display distinction if percentage is 75 or above.
10. Allow the user to search for a subject mark using its subject name.
11. Perform subject search case-insensitively.
12. Display a formatted result report.

CONSTRAINTS:
- Use arrays.
- Use for and foreach loops.
- Use strings and string methods.
- Use conditional statements.
- Use break and continue wherever appropriate.
- Do not use methods, LINQ, or advanced collections yet.
- Validate subject search input.
================================================================================
*/

using System;

namespace StudentResultReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Store student name and roll number
            Console.WriteLine("==========================================");
            Console.WriteLine("      STUDENT RESULT MANAGEMENT SYSTEM    ");
            Console.WriteLine("==========================================");

            Console.Write("Enter Student Name: ");
            string studentName = Console.ReadLine().Trim();
            while (string.IsNullOrWhiteSpace(studentName))
            {
                Console.Write("Name cannot be empty. Enter Student Name: ");
                studentName = Console.ReadLine().Trim();
            }

            Console.Write("Enter Roll Number: ");
            string rollNumber = Console.ReadLine().Trim();
            while (string.IsNullOrWhiteSpace(rollNumber))
            {
                Console.Write("Roll Number cannot be empty. Enter Roll Number: ");
                rollNumber = Console.ReadLine().Trim();
            }

            // 2. Accept marks for 6 subjects using an array
            const int subjectCount = 6;
            string[] subjects = { "Mathematics", "Physics", "Chemistry", "English", "Computer Science", "Biology" };
            int[] marks = new int[subjectCount];

            Console.WriteLine("\n--- Enter Marks (0 to 100) ---");
            for (int i = 0; i < subjectCount; i++)
            {
                while (true)
                {
                    Console.Write($"Enter marks for {subjects[i]}: ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out int mark) && mark >= 0 && mark <= 100)
                    {
                        marks[i] = mark;
                        break; // Valid input received, exit validation loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a number between 0 and 100.");
                        continue; // Skip to next iteration to re-prompt
                    }
                }
            }

            // 4, 6, 7. Calculate total, highest, lowest, and failed subject count
            int totalMarks = 0;
            int highestMark = marks[0];
            int lowestMark = marks[0];
            int failedCount = 0;

            foreach (int mark in marks)
            {
                totalMarks += mark;

                if (mark > highestMark)
                {
                    highestMark = mark;
                }

                if (mark < lowestMark)
                {
                    lowestMark = mark;
                }

                if (mark < 40)
                {
                    failedCount++;
                }
            }

            // 5. Calculate percentage
            double percentage = (double)totalMarks / (subjectCount * 100) * 100;

            // 8 & 9. Determine pass/fail status and distinction
            string status;
            if (failedCount > 0)
            {
                status = "FAIL";
            }
            else if (percentage >= 75.0)
            {
                status = "PASS WITH DISTINCTION";
            }
            else
            {
                status = "PASS";
            }

            // 3 & 12. Display a formatted result report with all subject marks
            Console.Clear();
            Console.WriteLine("==================================================");
            Console.WriteLine("              STUDENT RESULT REPORT               ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Student Name   : {studentName.ToUpper()}");
            Console.WriteLine($"Roll Number    : {rollNumber.ToUpper()}");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"{"Subject",-22} | {"Marks",8} | {"Remarks",-12}");
            Console.WriteLine("--------------------------------------------------");

            for (int i = 0; i < subjectCount; i++)
            {
                string remark = marks[i] < 40 ? "FAIL" : "PASS";
                Console.WriteLine($"{subjects[i],-22} | {marks[i],8} | {remark,-12}");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Total Marks    : {totalMarks} / {subjectCount * 100}");
            Console.WriteLine($"Percentage     : {percentage:F2}%");
            Console.WriteLine($"Highest Mark   : {highestMark}");
            Console.WriteLine($"Lowest Mark    : {lowestMark}");
            Console.WriteLine($"Failed Subjects: {failedCount}");
            Console.WriteLine($"Final Status   : {status}");
            Console.WriteLine("==================================================");

            // 10 & 11. Case-insensitive subject search with input validation
            Console.WriteLine("\n--- Subject Mark Search ---");
            while (true)
            {
                Console.Write("\nEnter subject name to search (or type 'exit' to quit): ");
                string searchQuery = Console.ReadLine().Trim();

                // Validate empty search input
                if (string.IsNullOrWhiteSpace(searchQuery))
                {
                    Console.WriteLine("Search input cannot be empty. Please enter a valid subject name.");
                    continue;
                }

                // Exit condition
                if (searchQuery.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Exiting search. Goodbye!");
                    break;
                }

                bool isFound = false;

                for (int i = 0; i < subjectCount; i++)
                {
                    if (subjects[i].Equals(searchQuery, StringComparison.OrdinalIgnoreCase))
                    {
                        string subStatus = marks[i] < 40 ? "Fail" : "Pass";
                        Console.WriteLine($"-> {subjects[i]}: {marks[i]} / 100 ({subStatus})");
                        isFound = true;
                        break; // Stop searching once the subject is found
                    }
                }

                if (!isFound)
                {
                    Console.WriteLine($"Subject '{searchQuery}' not found. Available subjects: {string.Join(", ", subjects)}");
                }
            }
        }
    }
}