/*
================================================================================
PROBLEM STATEMENT:
Build a console application demonstrating Object-Oriented Programming (OOP) 
principles by managing standard and graduate students and generating their 
result reports.

REQUIREMENTS:
Create at least:
- Two Student objects.
- One GraduateStudent object.
Display all details and results.

CONSTRAINTS:
- Use classes and objects.
- Use encapsulation.
- Use constructors.
- Use inheritance.
- Use method overriding.
- Use an interface.
- Use arrays and loops.
- Use proper access modifiers.
- No LINQ.
- No database.
- No ASP.NET.

BONUS CHALLENGE:
1. Add a static student counter that tracks the number of objects created.
2. Add constructor overloading.
3. Store students in a Student[] array.
4. Demonstrate runtime polymorphism using the array.
5. Prevent invalid marks from being assigned even after object creation.
================================================================================
*/

using System;

namespace StudentOOPManagement
{
    // Interface defining contract for report generation
    public interface IReportable
    {
        double CalculatePercentage();
        string GetResultStatus();
        void DisplayReport();
    }

    // Base class demonstrating Encapsulation, Constructors, and Interface implementation
    public class Student : IReportable
    {
        // Bonus 1: Static student counter
        private static int _studentCount = 0;

        // Encapsulated private fields
        private string _name;
        private string _rollNumber;
        private int[] _marks;

        // Public read-only property for static counter
        public static int TotalStudentsCreated
        {
            get { return _studentCount; }
        }

        // Encapsulated properties with validation
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Student name cannot be empty.");
                }
                _name = value.Trim();
            }
        }

        public string RollNumber
        {
            get { return _rollNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Roll number cannot be empty.");
                }
                _rollNumber = value.Trim().ToUpper();
            }
        }

        // Bonus 5: Prevent invalid marks from being assigned even after object creation
        public int[] Marks
        {
            get
            {
                // Return a defensive copy so external code cannot mutate internal array directly without validation
                int[] copy = new int[_marks.Length];
                for (int i = 0; i < _marks.Length; i++)
                {
                    copy[i] = _marks[i];
                }
                return copy;
            }
            set
            {
                if (value == null || value.Length == 0)
                {
                    throw new ArgumentException("Marks array cannot be null or empty.");
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] < 0 || value[i] > 100)
                    {
                        throw new ArgumentOutOfRangeException($"Invalid mark ({value[i]}) at index {i}. Marks must be between 0 and 100.");
                    }
                }

                _marks = new int[value.Length];
                for (int i = 0; i < value.Length; i++)
                {
                    _marks[i] = value[i];
                }
            }
        }

        // Bonus 2: Constructor Overloading (Default/Minimal Constructor)
        public Student(string name, string rollNumber)
        {
            Name = name;
            RollNumber = rollNumber;
            _marks = new int[5]; // Defaults to 0s
            _studentCount++;
        }

        // Bonus 2: Constructor Overloading (Parameterized Constructor)
        public Student(string name, string rollNumber, int[] marks)
        {
            Name = name;
            RollNumber = rollNumber;
            Marks = marks; // Uses property setter to enforce validation
            _studentCount++;
        }

        // Bonus 5: Safe method to update a single subject mark after object creation
        public void UpdateSubjectMark(int subjectIndex, int newMark)
        {
            if (subjectIndex < 0 || subjectIndex >= _marks.Length)
            {
                throw new IndexOutOfRangeException("Invalid subject index.");
            }
            if (newMark < 0 || newMark > 100)
            {
                throw new ArgumentOutOfRangeException($"Invalid mark ({newMark}). Marks must be between 0 and 100.");
            }
            _marks[subjectIndex] = newMark;
        }

        public int CalculateTotal()
        {
            int total = 0;
            foreach (int mark in _marks)
            {
                total += mark;
            }
            return total;
        }

        // Virtual methods to allow overriding in derived classes
        public virtual double CalculatePercentage()
        {
            int total = CalculateTotal();
            return (double)total / (_marks.Length * 100) * 100;
        }

        public virtual string GetResultStatus()
        {
            foreach (int mark in _marks)
            {
                if (mark < 40)
                {
                    return "FAIL";
                }
            }

            double percentage = CalculatePercentage();
            return percentage >= 75.0 ? "PASS WITH DISTINCTION" : "PASS";
        }

        public virtual void DisplayReport()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("           UNDERGRADUATE STUDENT REPORT           ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Roll Number   : {RollNumber}");
            Console.Write("Subject Marks : ");
            for (int i = 0; i < _marks.Length; i++)
            {
                Console.Write(_marks[i] + (i < _marks.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine($"Total Marks   : {CalculateTotal()} / {_marks.Length * 100}");
            Console.WriteLine($"Percentage    : {CalculatePercentage():F2}%");
            Console.WriteLine($"Result Status : {GetResultStatus()}");
            Console.WriteLine("==================================================\n");
        }
    }

    // Derived class demonstrating Inheritance and Method Overriding
    public class GraduateStudent : Student
    {
        private string _thesisTitle;
        private int _thesisScore;

        public string ThesisTitle
        {
            get { return _thesisTitle; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Thesis title cannot be empty.");
                }
                _thesisTitle = value.Trim();
            }
        }

        // Bonus 5: Validation on GraduateStudent property as well
        public int ThesisScore
        {
            get { return _thesisScore; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Thesis score must be between 0 and 100.");
                }
                _thesisScore = value;
            }
        }

        // Constructor chaining using base()
        public GraduateStudent(string name, string rollNumber, int[] marks, string thesisTitle, int thesisScore)
            : base(name, rollNumber, marks)
        {
            ThesisTitle = thesisTitle;
            ThesisScore = thesisScore;
        }

        // Method Overriding: Graduate percentage includes thesis score
        public override double CalculatePercentage()
        {
            int subjectTotal = CalculateTotal();
            int combinedTotal = subjectTotal + ThesisScore;
            int maxTotal = (Marks.Length * 100) + 100;
            return (double)combinedTotal / maxTotal * 100;
        }

        // Method Overriding: Graduate students require minimum 50 in subjects and thesis to pass
        public override string GetResultStatus()
        {
            if (ThesisScore < 50)
            {
                return "FAIL (Thesis Below 50)";
            }

            int[] currentMarks = Marks;
            foreach (int mark in currentMarks)
            {
                if (mark < 50)
                {
                    return "FAIL (Subject Below 50)";
                }
            }

            double percentage = CalculatePercentage();
            return percentage >= 80.0 ? "PASS WITH HONORS" : "PASS";
        }

        // Method Overriding: Custom report layout for GraduateStudent
        public override void DisplayReport()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("             GRADUATE STUDENT REPORT              ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Name          : {Name}");
            Console.WriteLine($"Roll Number   : {RollNumber}");
            Console.WriteLine($"Thesis Title  : {ThesisTitle}");
            Console.WriteLine($"Thesis Score  : {ThesisScore} / 100");
            Console.Write("Subject Marks : ");
            int[] currentMarks = Marks;
            for (int i = 0; i < currentMarks.Length; i++)
            {
                Console.Write(currentMarks[i] + (i < currentMarks.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();
            Console.WriteLine($"Combined Total: {CalculateTotal() + ThesisScore} / {(currentMarks.Length * 100) + 100}");
            Console.WriteLine($"Percentage    : {CalculatePercentage():F2}%");
            Console.WriteLine($"Result Status : {GetResultStatus()}");
            Console.WriteLine("==================================================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create two Student objects using overloaded constructors
                Student student1 = new Student("Aarav Sharma", "UG101", new int[] { 85, 78, 92, 88, 79 });

                Student student2 = new Student("Priya Patel", "UG102");
                student2.Marks = new int[] { 62, 55, 34, 70, 68 }; // Assigning marks after creation

                // Create one GraduateStudent object
                GraduateStudent gradStudent = new GraduateStudent(
                    "Rohan Verma",
                    "PG201",
                    new int[] { 82, 88, 91, 85, 89 },
                    "Distributed Consensus in Edge Computing",
                    92
                );

                // Bonus 3: Store students in a Student[] array
                Student[] students = new Student[] { student1, student2, gradStudent };

                // Bonus 1: Display total objects created via static counter
                Console.WriteLine($"Total Student Objects Created: {Student.TotalStudentsCreated}\n");

                // Bonus 4: Demonstrate runtime polymorphism using the base class array
                foreach (Student s in students)
                {
                    // Calls Student.DisplayReport() for Student objects and 
                    // GraduateStudent.DisplayReport() for GraduateStudent objects at runtime
                    s.DisplayReport();
                }

                // Bonus 5: Demonstrate post-creation mark validation
                Console.WriteLine("--- Testing Post-Creation Mark Validation ---");
                student2.UpdateSubjectMark(2, 105); // Attempting to assign invalid mark > 100
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Validation Blocked Action: {ex.Message}");
            }
        }
    }
}