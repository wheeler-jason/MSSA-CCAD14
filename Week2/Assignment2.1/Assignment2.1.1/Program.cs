namespace Assignment2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 2.1.1");
            Student student1 = new Student();
            student1.StudentFName = "John";
            student1.StudentLName = "Doe";
            student1.StudentId = 123;
            student1.StudentGrade = 'A';
            Console.WriteLine($"First Name: {student1.StudentFName}");
            Console.WriteLine($"Last Name: {student1.StudentLName}");
            Console.WriteLine($"Student ID: {student1.StudentId}");
            Console.WriteLine($"Grade: {student1.StudentGrade}");

        }
    }

    class Student 
    {
        private int _studentId;
        
        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        private string _studentFName;

        public string StudentFName
        {
            get { return _studentFName; }
            set { _studentFName = value; }
        }

        private string _studentLName;

        public string StudentLName
        {
            get { return _studentLName; }
            set { _studentLName = value; }
        }

        private char _studentGrade;

        public char StudentGrade
        {
            get { return _studentGrade; }
            set { _studentGrade = value; }
        }
    }
}
