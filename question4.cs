namespace StudentLibrary
{
    public class Student
    {
        public int Id;                // field
        private string secretCode;    // private field
        protected string guardianName;// protected field
        internal string collegeName;  // internal field
        public string Name { get; set; } // property
        public void Display() { }     // public method
        private void Calculate() { }  // private method
        protected void ShowGuardian() { } // protected method
        internal void ShowCollege() { }   // internal method
    }
}
using StudentLibrary;

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Id = 1;          // accessible
        s.Name = "Naresh"; // accessible
        s.Display();       // accessible
        // Try accessing others → compiler errors
    }
}
