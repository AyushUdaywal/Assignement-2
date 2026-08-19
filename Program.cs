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

public class Program
{
    public static void Main1()
    {
        Student s = new Student("Naresh", 22, "Computer Science", 8.5, "GLA University", "Mathura, UP");
        s.Display();
    }
}
