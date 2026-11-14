# Phase 01 — C# Fundamentals

## Overview

C# is a statically typed, object-oriented programming language developed by Microsoft. .NET is the development platform used to build and execute C# applications; it provides a runtime, libraries, and development tools.

## Concepts

### C#

- **Statically typed:** Variable types are checked by the compiler.
- **Object-oriented:** Programs can be organized around types and objects.
- Developed by Microsoft.

### .NET

A development platform for building and executing applications. It includes a runtime, libraries, and development tools.

### Important Terms

- **CLR (Common Language Runtime):** Executes .NET programs and provides services such as memory management.
- **IL (Intermediate Language):** Platform-independent instructions produced when C# code is compiled.
- **JIT (Just-In-Time) compiler:** Compiles IL into native machine code at runtime.
- **SDK (Software Development Kit):** Tools used to create, build, and publish .NET applications.
- **Runtime:** Components needed to run a .NET application.
- **Roslyn:** The .NET compiler platform used by C# and Visual Basic.
- **Top-level statements:** A simplified way to write a program without explicitly declaring a class and `Main` method.

## Syntax

### Execution Flow

```text
C# source code -> C# compiler -> IL -> CLR/JIT -> Native code
```

## Examples

## Common Mistakes

## Assessment Questions

## Practical Assignment 01 – Student Performance Report Generator

### Problem Statement

Read student details, marks for five subjects, attendance, previous CGPA, and active backlogs from the console. Calculate performance statistics, assign a grade, determine academic eligibility, and print a formatted report.

### Concepts Applied

- Console input with `Console.ReadLine()` and conversions using `Convert.ToInt32()` and `Convert.ToDecimal()`.
- `int`, `string`, `decimal`, and `bool` variables.
- Arithmetic, comparisons, and the logical AND (`&&`) operator.
- `Math.Max()` / `Math.Min()`, `if` / `else if` / `else`, and the ternary operator.
- String interpolation and `F2` numeric formatting.

### Important Concept Notes

- **`Console.ReadLine()`** reads a line of console input as text. For example: `string name = Console.ReadLine();`.
- **`Convert.ToInt32()`** converts input text to an integer, as used for marks and backlogs: `int subject1 = Convert.ToInt32(Console.ReadLine());`.
- **`Convert.ToDecimal()`** converts input text to a decimal number, as used for attendance and CGPA: `decimal attendance = Convert.ToDecimal(Console.ReadLine());`.
- **Decimal arithmetic and the `m` suffix:** The `m` suffix makes a numeric literal a `decimal`. The assignment uses `500m` and `5m` so percentage and average calculations use decimal arithmetic: `decimal averageMarks = totalMarks / 5m;`.
- **Integer division vs. decimal division:** Dividing two integers truncates any fractional part. Using a decimal operand preserves it; for example, `totalMarks / 5m` calculates a decimal average.
- **`Math.Max()` and `Math.Min()`:** Return the larger or smaller of two values. Nested calls compare the five subject marks to find the highest and lowest.
- **Logical AND (`&&`):** Is true only when every condition is true. Eligibility uses `attendance >= 75 && activeBacklogs == 0 && percentage >= 60`.
- **Ternary operator:** `condition ? valueWhenTrue : valueWhenFalse` selects one of two values. The report uses `{(isEligible ? "YES" : "NO")}`.
- **`F2` numeric formatting:** `{percentage:F2}` displays a number with two digits after the decimal point, such as `85.00`.

### Important Syntax Examples

```csharp
int subject1 = Convert.ToInt32(Console.ReadLine());
decimal attendance = Convert.ToDecimal(Console.ReadLine());
decimal percentage = (totalMarks / 500m) * 100;
int highestMarks = Math.Max(Math.Max(subject1, subject2), Math.Max(subject3, Math.Max(subject4, subject5)));
Console.WriteLine($"Percentage        : {percentage:F2}%");
Console.WriteLine($"Placement Eligible: {(isEligible ? "YES" : "NO")}");
```

### Calculation Formulas

- **Total marks:** `subject1 + subject2 + subject3 + subject4 + subject5`
- **Percentage:** `(totalMarks / 500m) * 100`
- **Average marks:** `totalMarks / 5m`
- **Highest / lowest:** Compare the five marks using nested `Math.Max()` / `Math.Min()` calls.

### Grade Classification Logic

The program checks percentage thresholds from highest to lowest:

- `>= 90`: A+
- `>= 80`: A
- `>= 70`: B
- `>= 60`: C
- `>= 50`: D
- Otherwise: F

### Academic Eligibility Condition

The student is eligible only when all three conditions are true:

```csharp
bool isEligible = attendance >= 75 && activeBacklogs == 0 && percentage >= 60;
```

### String Interpolation and Formatting

Interpolated strings use `$"..."` and `{expression}` to place values in report text. The assignment formats percentage and average to two decimal places and uses a ternary expression to print `YES` or `NO` for eligibility.

### Lessons Learned

- Convert console text to the appropriate numeric type before doing calculations.
- Use decimal operands in calculations where fractional results should be retained.
- Order grade checks from the highest threshold to the lowest.
- Combine all eligibility requirements with `&&` so every requirement must be met.
- Use interpolation to keep report labels and calculated values together.

### Common Mistakes

- Assuming `Console.ReadLine()` already returns a number instead of converting its text.
- Using integer division when a fractional decimal result is needed.
- Omitting the `m` suffix from decimal literals such as `500m` and `5m`.
- Checking grade thresholds in the wrong order.
- Using `||` instead of `&&` when all eligibility conditions must be satisfied.
- Forgetting that `F2` formats the displayed value; it does not change the stored value.

### Assessment Questions

1. What does `Console.ReadLine()` return, and why is conversion needed for marks?
2. Why does the percentage formula use `500m`?
3. What could happen to an average if it were calculated using integer division?
4. How do the nested `Math.Max()` and `Math.Min()` calls find the highest and lowest marks?
5. Why must all three eligibility checks be joined with `&&`?
6. What does `F2` do in an interpolated string?
7. Why are grade thresholds checked from highest to lowest?

## Practical Assignment 04 – Scholarship & Placement Eligibility Engine

### Problem Statement and Requirements

Read a student's CGPA, backlog count, family income, coding score, and attendance. Determine placement, scholarship, and coding-round eligibility; calculate a performance bonus; and display the results in a console report.

- **Placement:** CGPA >= 7.5, no backlogs, and attendance >= 75%.
- **Scholarship:** CGPA >= 8.0 and family income <= Rs. 3,00,000.
- **Coding round:** Coding score >= 60 or CGPA >= 9.0.
- **Performance bonus:** Rs. 10,000 for CGPA >= 9.0; Rs. 5,000 for CGPA >= 8.0; otherwise Rs. 0.

### Implementation Approach

The implementation reads values using `Console.ReadLine()`, converts CGPA, income, and attendance to `double` and backlogs and coding score to `int`, then uses Boolean expressions to determine eligibility. A nested ternary selects the bonus. Interpolated strings print the report, with `N0` formatting for income and bonus amounts.

The program currently reads interactive input. Input validation and exception handling are not implemented.

### Concepts Applied

- `Convert.ToDouble()` and `Convert.ToInt32()` for console input conversion.
- Relational operators (`>=`, `<=`, `==`) and logical AND (`&&`) / OR (`||`).
- `bool` variables for eligibility results.
- Nested ternary operator for selecting a bonus tier.
- String interpolation and `N0` numeric formatting.
- No loops, arrays, or custom methods.

### Key Learnings

- Combine every required condition with `&&`; use `||` when either condition can satisfy a rule.
- Apply each eligibility rule independently so one result does not stand in for another.
- Check nested ternary thresholds from highest to lowest to select the correct bonus.
- Numeric format strings such as `N0` affect display, not the underlying value.

### Future Improvements

- Validate entered values and handle malformed input.
- Use named constants for thresholds, attendance requirements, and bonus amounts.
- Update the assignment's introductory comment to reflect that the implementation reads values from the console.

## Revision Notes
