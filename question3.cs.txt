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
}

public class GraduateStudent : Student
{
    public GraduateStudent(string name, int age, string department, double cgpa, string college, string address)
        : base(name, age, department, cgpa, college, address) { }

    public void ShowData()
    {
        Console.WriteLine("Access through inheritance:");
        Console.WriteLine(Name);
        Console.WriteLine(Department);
        Console.WriteLine(CGPA);
        Console.WriteLine(College);
        Console.WriteLine(Address);

        Console.WriteLine("\nAccess through object:");
        Student s = new Student("Test", 21, "IT", 7.8, "GLA University", "Mathura");
        Console.WriteLine(s.Name);
        Console.WriteLine(s.CGPA);
        Console.WriteLine(s.College);
    }
}

public class question3
{
    public static void Main3()
    {
        GraduateStudent gs = new GraduateStudent("Naresh", 22, "Computer Science", 8.5, "GLA University", "Mathura, UP");
        gs.ShowData();
    }
}

