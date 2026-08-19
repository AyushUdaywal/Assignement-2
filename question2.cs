using System;

public class Student
{
    public string Name;
    private int Age;
    protected string Department;
    internal double CGPA;
    protected internal string College;
    private protected string Address;

    public Student(string name, int age, string department, double cgpa, string college, string address)
    {
        Name = name;
        Age = age;
        Department = department;
        CGPA = cgpa;
        College = college;
        Address = address;
    }

    public void Display()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("CGPA: " + CGPA);
        Console.WriteLine("College: " + College);
        Console.WriteLine("Address: " + Address);
    }
}

public class TestStudent
{
    public void CheckAccess()
    {
        Student s = new Student("Naresh", 22, "Computer Science", 8.5, "GLA University", "Mathura, UP");

        Console.WriteLine(s.Name);      // Accessible
        // Console.WriteLine(s.Age);    // Not accessible (private)
        // Console.WriteLine(s.Department); // Not accessible (protected)
        Console.WriteLine(s.CGPA);      // Accessible (internal, same assembly)
        Console.WriteLine(s.College);   // Accessible (protected internal, same assembly)
        // Console.WriteLine(s.Address); // Not accessible (private protected, only within same class or derived class in same assembly)
    }
}

public class question2
{
    public static void Main2()
    {
        TestStudent ts = new TestStudent();
        ts.CheckAccess();
    }
}
