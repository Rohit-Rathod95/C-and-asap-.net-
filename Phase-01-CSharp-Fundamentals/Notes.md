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

- **`Console.ReadLine()`** reads a line of console input as text.
- **`Convert.ToInt32()`** converts input text to an integer, as used for marks and backlogs.
- **`Convert.ToDecimal()`** converts input text to a decimal number, as used for attendance and CGPA.
- **Decimal arithmetic and the `m` suffix:** The `m` suffix makes a numeric literal a `decimal`; `500m` and `5m` support decimal percentage and average calculations.
- **Integer vs. decimal division:** Integer division truncates the fractional part; using `totalMarks / 5m` preserves a decimal result.
- **`Math.Max()` / `Math.Min()`:** Return the larger / smaller of two values; nested calls compare the five marks.
- **Logical AND (`&&`):** True only when every condition is true.
- **Ternary operator:** `condition ? valueWhenTrue : valueWhenFalse` selects one of two values.
- **`F2`:** Displays a number with two digits after the decimal point.

### Important Syntax Examples

```csharp
int subject1 = Convert.ToInt32(Console.ReadLine());
decimal attendance = Convert.ToDecimal(Console.ReadLine());
decimal percentage = (totalMarks / 500m) * 100;
Console.WriteLine($"Percentage: {percentage:F2}%");
```

### Calculation Formulas

- **Total:** `subject1 + subject2 + subject3 + subject4 + subject5`
- **Percentage:** `(totalMarks / 500m) * 100`
- **Average:** `totalMarks / 5m`
- **Highest / lowest:** Nested `Math.Max()` / `Math.Min()` calls.

### Grade Classification

Check thresholds from highest to lowest: `>= 90`: A+, `>= 80`: A, `>= 70`: B, `>= 60`: C, `>= 50`: D, otherwise F.

### Academic Eligibility

Eligible when attendance is at least 75%, there are no active backlogs, and percentage is at least 60%:

```csharp
bool isEligible = attendance >= 75 && activeBacklogs == 0 && percentage >= 60;
```

### String Interpolation and Formatting

Use `$"..."` with `{expression}` to insert values. The assignment uses `F2` for percentage and average, and a ternary expression to display eligibility.

### Lessons Learned

- Convert console text before calculating.
- Use decimal operands when fractional results are needed.
- Check grade thresholds from highest to lowest.
- Use `&&` when all eligibility conditions must be true.

### Common Mistakes

- Treating `Console.ReadLine()` as a number without conversion.
- Using integer division or omitting the `m` suffix.
- Checking grade thresholds in the wrong order.
- Using `||` instead of `&&` when all conditions must be true.
- Assuming `F2` changes the stored value rather than only its display.

### Assessment Questions

1. What does `Console.ReadLine()` return?
2. Why does the percentage formula use `500m`?
3. What is the difference between integer and decimal division?
4. Why must all eligibility checks use `&&`?
5. What does `F2` format?

## Practical Assignment 04 – Scholarship & Placement Eligibility Engine

### Problem Statement and Requirements

Read CGPA, backlog count, family income, coding score, and attendance. Determine eligibility and calculate a performance bonus.

- **Placement:** CGPA >= 7.5, no backlogs, and attendance >= 75%.
- **Scholarship:** CGPA >= 8.0 and family income <= Rs. 3,00,000.
- **Coding round:** Coding score >= 60 or CGPA >= 9.0.
- **Bonus:** Rs. 10,000 for CGPA >= 9.0; Rs. 5,000 for CGPA >= 8.0; otherwise Rs. 0.

### Implementation Approach

Read values from the console, convert them to `double` or `int`, evaluate eligibility with relational and logical operators, select the bonus with a nested ternary, and print an interpolated report using `N0` formatting.

Input validation and exception handling are not implemented.

### Concepts and Key Learnings

- Use `&&` when all requirements must hold and `||` when either condition is enough.
- Evaluate each eligibility rule independently.
- Check nested ternary thresholds from highest to lowest.
- `N0` formats displayed numbers; it does not change their values.
- The program does not use loops, arrays, or custom methods.

### Future Improvements

- Validate entered values and handle malformed input.
- Use named constants for thresholds and bonus amounts.
- Update the introductory code comment to match the interactive input behavior.

## Lesson 05: Conditional Statements in C#

Conditionals select code based on whether a condition or pattern matches.

### `if`

Runs its body when the condition is true.

```csharp
if (score >= 50) Console.WriteLine("Pass");
```

### `if-else`

Chooses one of two branches.

```csharp
if (isRaining) Console.WriteLine("Take an umbrella");
else Console.WriteLine("No umbrella needed");
```

### `else-if` Ladder

Checks conditions in order; the first true branch runs. Order overlapping ranges from highest to lowest.

```csharp
if (score >= 90) grade = "A";
else if (score >= 50) grade = "Pass";
else grade = "Fail";
```

### Nested `if`

An inner condition is checked only if its containing branch runs.

```csharp
if (hasAccount)
{
    if (passwordIsCorrect) Console.WriteLine("Signed in");
}
```

### `switch` Statement

Selects a statement section by matching a value; `break` exits that section.

```csharp
switch (day)
{
    case 1: Console.WriteLine("Monday"); break;
    default: Console.WriteLine("Other day"); break;
}
```

### Multiple Switch Cases

Case labels can share a body when their result is the same.

```csharp
switch (day)
{
    case 6:
    case 7: Console.WriteLine("Weekend"); break;
    default: Console.WriteLine("Weekday"); break;
}
```

### Switch Expression

Returns a value from the first matching arm; `_` is the fallback pattern.

```csharp
string grade = score switch { >= 90 => "A", >= 50 => "Pass", _ => "Fail" };
```

### Pattern Matching

Matches a value by type or other pattern; `when` adds a condition.

```csharp
string result = value switch
{
    string text when text.Length > 0 => text,
    _ => "No text"
};
```

### Relational Patterns

Use `<`, `<=`, `>`, or `>=` to match numeric ranges.

```csharp
string ageGroup = age switch { < 13 => "Child", < 20 => "Teen", _ => "Adult" };
```

### `if-else` vs. `switch` vs. Switch Expression

- **`if-else`:** General Boolean expressions and complex conditions.
- **`switch`:** Several alternatives with statement bodies.
- **Switch expression:** Maps alternatives to a value.

```csharp
string status = code switch { 200 => "OK", 404 => "Not found", _ => "Other" };
```

### Execution Flow

Conditions are evaluated in order; the selected branch executes, then control continues after the conditional.

```csharp
if (score >= 50) Console.WriteLine("Pass");
else Console.WriteLine("Fail");
Console.WriteLine("Done");
```

### Common Mistake and Interview Note

An `else-if` chain stops after its first match, unlike independent `if` statements. Use `==` for equality, not `=`.

### MCQs

1. What does a switch expression return? **Answer:** The value of its matching arm.
2. What does `when` add to a pattern? **Answer:** An extra condition that must be true.

## Lesson 06: Loops in C#

Loops repeat statements while there are more iterations or items to process.

### `for` Loop and Its Parts

Initialization runs once, the condition is checked before each iteration, and update runs after the body.

```csharp
for (int i = 1; i <= 3; i++)
    Console.WriteLine(i);
```

### `while` Loop

Checks its condition before each iteration; it may run zero times.

```csharp
int count = 1;
while (count <= 3) { Console.WriteLine(count); count++; }
```

### `do-while` Loop

Checks its condition after the body, so it runs at least once.

```csharp
int count = 1;
do { Console.WriteLine(count); count++; } while (count <= 3);
```

### `foreach` Loop

Visits each item in a collection without managing an index.

```csharp
foreach (string subject in subjects) Console.WriteLine(subject);
```

### `break`

Exits the nearest loop immediately.

```csharp
for (int i = 1; i <= 5; i++) { if (i == 3) break; Console.WriteLine(i); }
```

### `continue`

Skips the rest of the current iteration.

```csharp
for (int i = 1; i <= 3; i++) { if (i == 2) continue; Console.WriteLine(i); }
```

### Nested Loops

The inner loop completes for each outer-loop iteration.

```csharp
for (int row = 1; row <= 2; row++)
    for (int column = 1; column <= 2; column++)
        Console.WriteLine($"{row},{column}");
```

### Pattern Printing

Use the outer loop for rows and the inner loop for characters in each row.

```csharp
for (int row = 1; row <= 3; row++)
{
    for (int column = 1; column <= row; column++) Console.Write("*");
    Console.WriteLine();
}
```

### Infinite Loops

A loop is infinite if its condition never becomes false; include an exit when needed.

```csharp
while (true) { if (Console.ReadLine() == "quit") break; }
```

### Loop Execution Flow

`for`: initialize → condition → body → update. `while`: condition → body. `do-while`: body → condition. `foreach`: next item → body. `break` exits; `continue` advances to the next iteration.

### Student Marks Analyzer

Use a loop to total marks; cast before division to preserve a fractional average.

```csharp
int[] marks = { 78, 85, 92 };
int total = 0;
foreach (int mark in marks) total += mark;
double average = (double)total / marks.Length;
Console.WriteLine($"Average: {average:F2}");
```

### Common Mistakes and Interview Notes

- Update a `while` loop counter so its condition can eventually become false.
- `do-while` runs at least once; `while` may not run at all.
- `break` exits the nearest loop; `continue` skips to its next iteration.
- Nested loops multiply iterations (for example, 2 outer × 3 inner = 6 inner-body executions).
- Avoid dividing by zero when a collection may be empty.

### MCQs

1. Which loop always executes at least once? **Answer:** `do-while`.
2. What does `continue` do? **Answer:** Skips the rest of the current iteration.
3. If an outer loop runs 3 times and an inner loop runs 2 times per outer iteration, how many inner-body runs occur? **Answer:** 6.

## Revision Notes
