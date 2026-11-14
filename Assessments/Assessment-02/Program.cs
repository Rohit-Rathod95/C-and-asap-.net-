/**
 * Assignment: Scholarship & Placement Eligibility Engine
 * Build a console application using only concepts learned so far.
 *
 * Requirements:
 * 1. Store CGPA, backlogs, family income, coding score, and attendance.
 * 2. Determine placement eligibility:
 *    - CGPA >= 7.5
 *    - No backlogs
 *    - Attendance >= 75%
 * 3. Determine scholarship eligibility:
 *    - CGPA >= 8.0
 *    - Family income <= Rs. 3,00,000
 * 4. Determine coding round eligibility:
 *    - Coding score >= 60 OR CGPA >= 9.0
 * 5. Calculate a performance bonus:
 *    - CGPA >= 9.0 -> Rs. 10,000
 *    - CGPA >= 8.0 -> Rs. 5,000
 *    - Otherwise   -> Rs. 0
 * 6. Print all eligibility results and bonus.
 *
 * Constraints:
 * - Use relational, logical, assignment, and ternary operators.
 * - Use nested ternary where appropriate.
 * - No loops, arrays, or custom methods yet.
 * - No user input required; hardcode sample data.
 */

using System;

class Program
{
    static void Main()
    {
        // 1. Hardcoded sample data
        //double cgpa = 8.33;
        Console.WriteLine("Enter CGPA: ");
        double cgpa = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Backlogs: ");
        int backlogs = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Family Income: ");
        double familyIncome = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Coding Score: ");
        int codingScore = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Attendance: ");
        double attendance = Convert.ToDouble(Console.ReadLine());

        // 2. Placement eligibility (Relational + Logical AND)
        bool isPlacementEligible = (cgpa >= 7.5) && (backlogs == 0) && (attendance >= 75.0);

        // 3. Scholarship eligibility (Relational + Logical AND)
        bool isScholarshipEligible = (cgpa >= 8.0) && (familyIncome <= 300000);

        // 4. Coding round eligibility (Relational + Logical OR)
        bool isCodingRoundEligible = (codingScore >= 60) || (cgpa >= 9.0);

        // 5. Performance bonus (Nested Ternary)
        int performanceBonus = (cgpa >= 9.0) ? 10000 : ((cgpa >= 8.0) ? 5000 : 0);

        // 6. Output results (Ternary for readable status)
        Console.WriteLine("=================================================");
        Console.WriteLine("   SCHOLARSHIP & PLACEMENT ELIGIBILITY REPORT    ");
        Console.WriteLine("=================================================");
        Console.WriteLine($"CGPA                  : {cgpa}");
        Console.WriteLine($"Backlogs              : {backlogs}");
        Console.WriteLine($"Family Income         : Rs. {familyIncome:N0}");
        Console.WriteLine($"Coding Score          : {codingScore}");
        Console.WriteLine($"Attendance            : {attendance}%");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine($"Placement Eligible    : {(isPlacementEligible ? "Yes" : "No")}");
        Console.WriteLine($"Scholarship Eligible  : {(isScholarshipEligible ? "Yes" : "No")}");
        Console.WriteLine($"Coding Round Eligible : {(isCodingRoundEligible ? "Yes" : "No")}");
        Console.WriteLine($"Performance Bonus     : Rs. {performanceBonus:N0}");
        Console.WriteLine("=================================================");
    }
}