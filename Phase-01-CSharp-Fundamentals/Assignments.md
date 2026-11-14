# Phase 01 — Assignments

Use one entry per assignment. Keep source code in the relevant topic folder and link to it from **Solution location**.

## Assignment [number] — [title]

- **Assignment number:**
- **Problem statement:**
- **Requirements:**
- **Approach:**
- **Solution location:**
- **Status:** Not started / In progress / Complete
- **Learnings:**

## Assignment 01 — Student Performance Report Generator

- **Assignment:** Student Performance Report Generator
- **Status:** Completed
- **Difficulty:** Intermediate
- **Concepts practiced:** `Console.ReadLine()`, `Convert.ToInt32()`, `Convert.ToDecimal()`, `int`, `string`, `decimal`, and `bool`; arithmetic and decimal division; `Math.Max()` / `Math.Min()`; `if` / `else if` / `else`; comparisons and logical AND (`&&`); ternary operator; string interpolation; `F2` numeric formatting.
- **Solution location:** `Assessments/Assessment-01/Program.cs`
- **Git commit reference:** [Add commit hash or link]

## Assignment 04 — Scholarship & Placement Eligibility Engine

- **Assignment:** Scholarship & Placement Eligibility Engine
- **Status:** Completed
- **Requirements:** Determine placement eligibility (CGPA >= 7.5, no backlogs, attendance >= 75%), scholarship eligibility (CGPA >= 8.0 and family income <= Rs. 3,00,000), and coding-round eligibility (coding score >= 60 or CGPA >= 9.0). Calculate a performance bonus of Rs. 10,000 for CGPA >= 9.0, Rs. 5,000 for CGPA >= 8.0, or Rs. 0 otherwise, and print the results.
- **Implementation approach:** Read CGPA, backlogs, family income, coding score, and attendance from console input; convert to `double` or `int`; evaluate eligibility with relational and logical operators; use a nested ternary for the bonus and interpolated strings to display a formatted report.
- **Key learnings:** Use `&&` when every condition must hold and `||` when either condition is sufficient. Order nested ternary thresholds from highest to lowest. Use number formatting such as `N0` for readable whole-number output.
- **Future improvements:** Add input validation and clear handling for invalid values; use named constants for eligibility thresholds and bonus amounts; align the assignment comment with the interactive input behavior.
- **Solution location:** `Assessments/Assessment-02/Program.cs`
