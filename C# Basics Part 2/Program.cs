//C# Control Flow
Console.WriteLine("For loop countdown: \n");

for (int i = 1; i < 11; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n");

// While loop bonus
Console.WriteLine("While loop countdown: \n");

{
    int i = 5;

    while (i > 0){
        Console.WriteLine(i);
        i--;
    }
}
Console.WriteLine("\n");


//C# Arrays

// Create days of week array
string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

foreach ( string day in daysOfWeek)
{
    Console.WriteLine(day);
}
Console.WriteLine("\n");


// Sum of ints

int[] arrayOfInts = { 4, 2, 7, 89, 23, 44, 89, 21, 3, 15 };
int total =0;
foreach ( int i in arrayOfInts)
{
    total += i;
}
Console.WriteLine("The total amount in the array is: "+total);

/* Multidimintional arrays are arrays with more than one dimension, and are used for many things such as matrix calculations
as well as tabulating data. They are used instances in which you would like to store an array of arrays. An example would of its use
would be: A company contains multiple depratments and each department contains multiple employees, to properly tabulate the 
employee data you can store the employees in an array of their department and then store the department in an array called company.*/

// Implementing the example

string[] itDepratment = { "Aziz", "Ahmed", "Farah" };
string[] financeDepartment = { "Hawraa", "Ali", "Moe", "Sarah" };
string[] hrDepartment = { "Sam", "Yone" };

string[][] company = {itDepratment, financeDepartment, hrDepartment };