/*
================================================================================
PROBLEM STATEMENT:
Build a console application that accepts student information and validates it 
using exception handling.

REQUIREMENTS:
1.  Accept student name.
2.  Accept roll number.
3.  Accept marks for five subjects.
4.  Validate marks between 0 and 100.
5.  Handle invalid integer input.
6.  Handle empty student names.
7.  Handle division by zero.
8.  Calculate total and percentage.
9.  Display a formatted report.
10. Create a custom InvalidMarksException.

CONSTRAINTS:
- Use arrays.
- Use loops.
- Use methods.
- Use try-catch.
- Use multiple catch blocks.
- Use finally.
- Use throw.
- Use a custom exception.
- Do not use LINQ.

CHALLENGE:
Create a method that calculates the percentage while safely handling division by 
zero, and a method that validates marks using the custom InvalidMarksException.
================================================================================
*/

using System;

namespace StudentExceptionValidation
{
    // 10. Custom InvalidMarksException
    public class InvalidMarksException : Exception
    {
        public InvalidMarksException() : base("Marks must be between 0 and 100.") { }
        public InvalidMarksException(string message) : base(message) { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            const int subjectCount = 5;
            string[] subjects = { "Mathematics", "Physics", "Chemistry", "English", "Computer Science" };
            int[] marks = new int[subjectCount];
            string studentName = string.Empty;
            string rollNumber = string.Empty;

            try
            {
                Console.WriteLine("================================================");
                Console.WriteLine("      STUDENT INFORMATION & RESULT SYSTEM       ");
                Console.WriteLine("================================================");

                // 1 & 6. Accept and validate student name
                Console.Write("Enter Student Name: ");
                studentName = Console.ReadLine();
                ValidateName(studentName);

                // 2. Accept roll number
                Console.Write("Enter Roll Number: ");
                rollNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(rollNumber))
                {
                    throw new ArgumentException("Roll number cannot be empty.");
                }

                // 3, 4 & 5. Accept and validate marks for five subjects
                Console.WriteLine("\n--- Enter Subject Marks (0 - 100) ---");
                for (int i = 0; i < subjectCount; i++)
                {
                    while (true)
                    {
                        try
                        {
                            Console.Write($"Enter marks for {subjects[i]}: ");
                            string input = Console.ReadLine();

                            // Throws FormatException if non-numeric, OverflowException if out of int bounds
                            int enteredMark = int.Parse(input);

                            // Throws InvalidMarksException if outside 0 - 100
                            ValidateMarks(enteredMark);

                            marks[i] = enteredMark;
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Invalid integer input. Please enter numeric digits only.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Error: Number entered is too large or too small.");
                        }
                        catch (InvalidMarksException ex)
                        {
                            Console.WriteLine($"Validation Error: {ex.Message}");
                        }
                    }
                }

                // 7 & 8. Calculate total and percentage
                int totalMarks = CalculateTotal(marks);
                double percentage = CalculatePercentage(totalMarks, subjectCount);

                // 9. Display formatted report
                DisplayReport(studentName.Trim(), rollNumber.Trim(), subjects, marks, totalMarks, percentage);
            }
            catch (ArgumentException ex)
            {
                // Handles empty name or roll number
                Console.WriteLine($"\nInput Error: {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                // Handles division by zero during percentage calculation
                Console.WriteLine($"\nMath Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Fallback catch block for any unexpected errors
                Console.WriteLine($"\nUnexpected Error: {ex.Message}");
            }
            finally
            {
                // Always executes regardless of whether an exception occurred
                Console.WriteLine("\n================================================");
                Console.WriteLine("Process execution completed. Resources cleaned up.");
                Console.WriteLine("================================================");
            }
        }

        // Method to validate student name
        static void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Student name cannot be empty or whitespace.");
            }
        }

        // Method to validate marks using custom exception
        static void ValidateMarks(int mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new InvalidMarksException($"Invalid mark ({mark}). Marks must be between 0 and 100.");
            }
        }

        // Method to calculate total marks using a loop (no LINQ)
        static int CalculateTotal(int[] marks)
        {
            int total = 0;
            foreach (int mark in marks)
            {
                total += mark;
            }
            return total;
        }

        // Challenge Method: Calculate percentage and explicitly guard against division by zero
        static double CalculatePercentage(int totalMarks, int subjectCount)
        {
            if (subjectCount == 0)
            {
                throw new DivideByZeroException("Cannot calculate percentage when subject count is zero.");
            }

            return (double)totalMarks / (subjectCount * 100) * 100;
        }

        // Method to display the formatted result report
        static void DisplayReport(string name, string rollNo, string[] subjects, int[] marks, int total, double percentage)
        {
            Console.WriteLine("\n================================================");
            Console.WriteLine("             STUDENT RESULT REPORT              ");
            Console.WriteLine("================================================");
            Console.WriteLine($"Student Name : {name.ToUpper()}");
            Console.WriteLine($"Roll Number  : {rollNo.ToUpper()}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"{"Subject",-22} | {"Marks",8} | {"Status",-10}");
            Console.WriteLine("------------------------------------------------");

            bool hasFailed = false;
            for (int i = 0; i < subjects.Length; i++)
            {
                string subStatus = marks[i] < 40 ? "FAIL" : "PASS";
                if (marks[i] < 40)
                {
                    hasFailed = true;
                }
                Console.WriteLine($"{subjects[i],-22} | {marks[i],8} | {subStatus,-10}");
            }

            string finalResult = hasFailed ? "FAIL" : (percentage >= 75.0 ? "DISTINCTION" : "PASS");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Total Marks  : {total} / {subjects.Length * 100}");
            Console.WriteLine($"Percentage   : {percentage:F2}%");
            Console.WriteLine($"Final Result : {finalResult}");
            Console.WriteLine("================================================");
        }
    }
}