int age = 20;

if (age >= 18)
{
    Console.WriteLine("Eligible to vote");
}  



int marks = 35;

if (marks >= 90)
{
    Console.WriteLine("Grade A+");
}
else if (marks >= 80)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 70)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade C");
}
else if (marks >= 40)
{
    Console.WriteLine("Grade D");
}
else
{
    Console.WriteLine("Fail");
}  


double cgpa = 8.5;
int backlogs = 0;
double attendance = 85;

if (cgpa >= 7.5)
{
    if (backlogs == 0)
    {
        if (attendance >= 75)
        {
            Console.WriteLine("Placement Eligible");
        }
        else
        {
            Console.WriteLine("Attendance insufficient");
        }
    }
    else
    {
        Console.WriteLine("Backlogs present");
    }
}
else
{
    Console.WriteLine("CGPA insufficient");
}  


int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    case 4:
        Console.WriteLine("Thursday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;
}  


int num=5;
string dayName=num switch
{
    1=>"Monday",
    2=>"Tuesday",
    3=>"Wednesday",
    4=>"Thursday",
    5=>"Friday",
    6=>"Saturday",
    7=>"Sunday",
    _=>"Invalid day"
};
Console.WriteLine(dayName); 

double sgpa = 8.33;

string scholarship = sgpa switch
{
    >= 9.0 => "Full Scholarship",
    >= 8.0 => "Partial Scholarship",
    >= 7.0 => "Merit Consideration",
    _ => "Not Eligible"
};

Console.WriteLine(scholarship);