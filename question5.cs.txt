using StudentLibrary;

{
    public class Student
    {
        protected string guardianName;
        protected internal string projectTitle;
        private protected string thesisCode;
        public string Name { get; set; }
    }
}

class ResearchStudent : Student
{
    public void TestAccess()
    {
        guardianName = "Mr. Sharma";
        projectTitle = "AI Research";
        Name = "Naresh";
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Naresh";
    }
}
