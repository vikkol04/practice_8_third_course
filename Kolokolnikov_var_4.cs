using System;
namespace ConsoleApp1
{
    internal class KolokolnikovVar4
    {
        public class Person
        {
            private string firstName, lastName;
            public Person(string toFirstName, string toLastName)
            {
                firstName = toFirstName;
                lastName = toLastName;
            }
            public string FirstName 
            {
                get { return firstName; }
                set { firstName = value; }
            }
            public string LastName 
            {
                get { return lastName; }
                set { lastName = value; }
            }
        }

        public class Student : Person, ILearnable
        {
            public int grade;
            public Student(string toFirstName, string toLastName, int toGrade) : base(toFirstName, toLastName)
            {
                Grade = toGrade;
            }
            public int Grade 
            {
                get { return grade; }
                set { grade = value; }
            }
            public void Learn()
            {
                Console.WriteLine($"Student {FirstName} {LastName} gets an {Grade}");
            }
        }
        public interface ILearnable
        {
            void Learn();
        }
        static void Main (string[] args)
        {
            /*  Create a Person class with the firstName and lastName properties.
                Add a constructor, getters, and setters. Create a Student class 
                that inherits from Person and has an additional property grade.
                Implement the ILearnable interface with the Learn() method in 
                the Student class.  */
            Console.WriteLine($"\n\nVar 4. --------------------------------------------------------\n");
            Console.ReadLine();
            string input = "";
            Person MyPerson = new Person("Olga", "Ephremova");
            Console.WriteLine("Person");
            do
            {
                Console.Write("Enter (getFN, setFN, getLN, setLN): ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "getFN":
                        Console.WriteLine("FirstName: " + MyPerson.FirstName);
                        break;
                    case "setFN":
                        Console.Write("Enter new FirstName: ");
                        MyPerson.FirstName = Console.ReadLine();
                        break;
                    case "getLN":
                        Console.WriteLine("LastName: " + MyPerson.LastName);
                        break;
                    case "setLN":
                        Console.Write("Enter new LastName: ");
                        MyPerson.LastName = Console.ReadLine();
                        break;
                }
            }
            while (input != "");
            Console.WriteLine("Person is finished.");

            input = "";
            Student MyStudent = new Student("Ivan", "Nerevarin", 5);
            Console.WriteLine("Student");
            do
            {
                Console.Write("Enter (getFN, setFN, getLN, setLN, getG, setG, learn): ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "getFN":
                        Console.WriteLine("FirstName: " + MyStudent.FirstName);
                        break;
                    case "setFN":
                        Console.Write("Enter new FirstName: ");
                        MyStudent.FirstName = Console.ReadLine();
                        break;
                    case "getLN":
                        Console.WriteLine("LastName: " + MyStudent.LastName);
                        break;
                    case "setLN":
                        Console.Write("Enter new LastName: ");
                        MyStudent.LastName = Console.ReadLine();
                        break;
                    case "getG":
                        Console.WriteLine("Grade: " + MyStudent.Grade);
                        break;
                    case "setG":
                        Console.Write("Enter new grade: ");
                        MyStudent.Grade = Convert.ToInt32(Console.ReadLine());
                        break;
                    case "learn":
                        MyStudent.Learn();
                        break;
                }
            }
            while (input != "");
            Console.WriteLine("Student is finished.");
        }
    }
}
