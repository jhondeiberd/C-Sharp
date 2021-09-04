using System;

namespace _05___Student {
   class Student {
      // static fields
      private static int numberOfStudents = 0;

      // static function member (=method)
      public static int GetNumberOfStudents() {
         return Student.numberOfStudents;
      }

      // instance fields
      private string lastName;
      private long? phoneNumber;

      // properties (to read/write a private hidden data member of type string)
      public string FirstName { get; set; }

      // constructors (= methods)
      public Student(string name, long? phoneNumber = null)
         : this(name) {
         this.phoneNumber = phoneNumber;
      }
      public Student(string name) {
         Student.numberOfStudents++;
         if (name == null) {
            throw new Exception("student's name cannot be null!");
         }
         this.lastName = name;
         this.phoneNumber = null;
      }
      public Student(string lastName, string firstName) : this(lastName) {
         this.FirstName = firstName;
         this.phoneNumber = null;
      }

      // function members (= methods)
      public void PrintInfo() {
         Console.WriteLine("Name : {0}", this.lastName);
         Console.WriteLine("Phone number : {0}", this.phoneNumber);
      }
   }

   class StudentTest {
      static Student[] students = new Student[5];

      public static void CreateStudents() {
         students[0] = new Student("Rohit");
         students[1] = new Student("Parsa");
         students[2] = new Student("Hamza");
         students[3] = new Student("Anuj");
         students[4] = new Student("Ricardo");
      }
   }

   class Program {
      static void Main(string[] args) {
         Console.WriteLine("Nb of students = {0}", Student.GetNumberOfStudents());
         Student stu1 = new Student("toto");
         stu1.PrintInfo();
         Console.WriteLine("Nb of students = {0}", Student.GetNumberOfStudents());
         Student stu2 = new Student("toto", 5156237007);
         Console.WriteLine("Nb of students = {0}", Student.GetNumberOfStudents());

         stu1.FirstName = "titi";   // using the set method of the property
         Console.WriteLine(stu1.FirstName);  // using the get method of the property

         StudentTest.CreateStudents();
      }
   }
}
