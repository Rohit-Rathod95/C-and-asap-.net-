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

## Lesson 10: Object-Oriented Programming (OOP)

Object-Oriented Programming (OOP) is a programming model that organizes code around objects and classes instead of writing everything as a single procedure. It helps make software easier to understand, reuse, extend, and maintain.

### 1) OOP Definition and the Four Pillars

OOP is a design approach where data and the operations that work on that data are grouped together into objects.

The four main pillars of OOP are:

- **Encapsulation:** Hiding internal details and exposing only what is necessary.
- **Abstraction:** Showing only important behavior and hiding complexity.
- **Inheritance:** Creating a new class from an existing class to reuse code.
- **Polymorphism:** Allowing one interface to take many forms.

These pillars help build modular and scalable applications.

### 2) Classes and Objects

A **class** is a blueprint or template.

An **object** is an instance of a class.

```csharp
class Employee
{
    public string Name;
}

Employee emp1 = new Employee();
emp1.Name = "Riya";

Employee emp2 = new Employee();
emp2.Name = "Aman";
```

- `Employee` is the class.
- `emp1` and `emp2` are objects.
- Each object has its own data.

### 3) Fields vs Properties

A **field** is a variable declared inside a class. It stores data.

```csharp
class Employee
{
    public string name; // field
}
```

A **property** is a member that provides access to private data with controlled logic.

```csharp
class Employee
{
    private string name; // field

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
```

#### Difference

- **Fields** are usually used for internal storage.
- **Properties** are used for controlled external access.
- Properties can validate values, compute values, or protect data.

### 4) Auto-Properties and Property Validation

C# provides **auto-properties** for simple properties.

```csharp
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}
```

This is shorter and cleaner, but it still may need validation.

#### Property Validation

```csharp
class Employee
{
    private string name;

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }
}
```

This ensures the object remains valid.

### 5) Constructors and Constructor Overloading

A **constructor** is a special method used to initialize an object when it is created.

```csharp
class Employee
{
    public string Name;

    public Employee()
    {
        Name = "Unknown";
    }
}
```

#### Constructor Overloading

A class can have more than one constructor with different parameter lists.

```csharp
class Employee
{
    public string Name;
    public int Id;

    public Employee()
    {
        Name = "Unknown";
        Id = 0;
    }

    public Employee(string name, int id)
    {
        Name = name;
        Id = id;
    }
}
```

```csharp
Employee e1 = new Employee();
Employee e2 = new Employee("Rahul", 101);
```

This is called **constructor overloading**.

### 6) `this` Keyword

`this` refers to the current instance of the class.

```csharp
class Employee
{
    public string Name;

    public Employee(string name)
    {
        this.Name = name;
    }
}
```

It is often used to:

- distinguish class fields from parameters
- call another constructor
- refer to the current object

### 7) Access Modifiers

Access modifiers control visibility and access level of members.

Common ones:

- **public:** accessible from anywhere
- **private:** accessible only inside the same class
- **protected:** accessible inside the class and derived classes
- **internal:** accessible within the same assembly

```csharp
class Employee
{
    public string Name;      // accessible everywhere
    private int salary;      // accessible only inside class
    protected string dept;   // accessible in derived classes
}
```

### 8) Encapsulation

Encapsulation means hiding the internal state of an object and exposing only the required operations.

```csharp
class Employee
{
    private decimal salary;

    public decimal Salary
    {
        get { return salary; }
        set
        {
            if (value >= 0)
                salary = value;
        }
    }
}
```

This ensures:

- controlled access
- data protection
- less chance of invalid states

### 9) Inheritance and Constructor Chaining Using `base`

Inheritance allows a class to inherit properties and methods from another class.

```csharp
class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

class Employee : Person
{
    public int Id { get; set; }

    public Employee(string name, int id) : base(name)
    {
        Id = id;
    }
}
```

- `Employee` inherits from `Person`.
- `base(name)` calls the constructor of the base class.
- This is called **constructor chaining**.

### 10) Method Overloading vs Overriding

#### Method Overloading

Multiple methods in the same class share the same name but have different parameters.

```csharp
class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
}
```

This is resolved at compile time.

#### Method Overriding

A derived class provides a different implementation of a base class method.

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Dog barks");
    }
}
```

- Overloading = same class, different signature
- Overriding = base and derived class, same method name/signature

### 11) Runtime Polymorphism Using `virtual` and `override`

Polymorphism means one object can be treated as a different type depending on runtime behavior.

```csharp
Animal a = new Dog();
a.Speak();
```

Output:

```text
Dog barks
```

This works because:

- the base method is marked `virtual`
- the derived method is marked `override`

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Animal speaks");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Cat meows");
    }
}
```

This is the heart of **runtime polymorphism**.

### 12) Abstract Classes and Abstract Methods

An **abstract class** cannot be instantiated directly.

It may contain both abstract and concrete members.

```csharp
abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }
}
```

- `abstract` method has no body
- derived classes must implement it
- abstract classes are used for common behavior and design

### 13) Interfaces

An **interface** defines a contract. A class implements it by providing the required members.

```csharp
interface IPrintable
{
    void Print();
}

class Invoice : IPrintable
{
    public void Print()
    {
        Console.WriteLine("Invoice printed");
    }
}
```

- interfaces do not contain implementation
- a class can implement multiple interfaces
- interfaces help achieve loose coupling

### 14) Abstract Class vs Interface

| Concept | Abstract Class | Interface |
|---|---|---|
| Can have implementation | Yes | No |
| Multiple inheritance | No | Yes |
| Can contain fields | Yes | No (except constants) |
| Used for shared base behavior | Yes | No |
| Used for contracts | Sometimes | Yes |

**Use an abstract class** when classes share common code.

**Use an interface** when you want to define a contract that many unrelated classes can implement.

### 15) Static Members

A **static member** belongs to the class, not to a single instance.

```csharp
class MathHelper
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

int result = MathHelper.Add(5, 7);
```

Static members are accessed using the class name.

Important points:

- static fields are shared across all instances
- static methods cannot access instance members without an object
- static members are used for utility functions and shared data

### 16) Object Initializers

Object initializers let you assign values to members when creating an object.

```csharp
Employee emp = new Employee
{
    Name = "Neha",
    Id = 201,
    Department = "Engineering"
};
```

This is cleaner than manually setting properties one by one.

### 17) Complete Employee/Developer Example

```csharp
using System;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Department { get; set; }

    public Employee()
    {
        Name = "Unknown";
        Department = "General";
    }

    public Employee(string name, int id, string department)
    {
        Name = name;
        Id = id;
        Department = department;
    }

    public virtual void Display()
    {
        Console.WriteLine($"Employee: {Name}, Id: {Id}, Department: {Department}");
    }
}

class Developer : Employee
{
    public string Skill { get; set; }

    public Developer(string name, int id, string department, string skill)
        : base(name, id, department)
    {
        Skill = skill;
    }

    public override void Display()
    {
        Console.WriteLine($"Developer: {Name}, Id: {Id}, Department: {Department}, Skill: {Skill}");
    }
}

class Program
{
    static void Main()
    {
        Employee e1 = new Employee("Rohan", 101, "HR");
        e1.Display();

        Developer d1 = new Developer("Anu", 202, "IT", "C#");
        d1.Display();

        Employee e2 = new Developer("Karan", 303, "Software", "ASP.NET");
        e2.Display();
    }
}
```

#### Example Explanation

- `Employee` is a base class.
- `Developer` inherits from `Employee`.
- `base(name, id, department)` calls the parent constructor.
- `Display()` is overridden to provide developer-specific output.
- `Employee e2 = new Developer(...)` shows runtime polymorphism.

### 18) Important Interview Questions and Mistakes

#### Common Interview Questions

1. What is the difference between a class and an object?
2. What are the four pillars of OOP?
3. What is the difference between a field and a property?
4. What is the purpose of `this`?
5. What is method overloading and method overriding?
6. What is the difference between an abstract class and an interface?
7. Why is encapsulation important?
8. What is runtime polymorphism?
9. Why use `virtual` and `override` together?
10. What is constructor chaining with `base`?

#### Common Mistakes

- Declaring fields as `public` and exposing internal state directly.
- Forgetting to mark overridden methods with `override`.
- Using `new` to hide a base method instead of proper overriding.
- Not calling `base(...)` in derived constructors when needed.
- Confusing method overloading with method overriding.
- Using `static` where instance behavior is required.
- Forgetting to make base methods `virtual` before overriding them.
- Thinking an abstract class can be instantiated.
- Not understanding that interfaces define contracts, not implementation.

### Quick Summary

OOP helps us model real-world entities using classes and objects. The core ideas like encapsulation, inheritance, polymorphism, and abstraction make code cleaner, reusable, and easier to maintain. In C#, these concepts are used heavily in application development, design patterns, and interviews.

### Interview Tip

When answering OOP questions in interviews, explain both the concept and a small code example. This shows clarity, understanding, and practical implementation skill.

## Revision Notes
