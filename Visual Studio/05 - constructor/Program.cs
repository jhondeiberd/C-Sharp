using System;

namespace _05___constructor {
   class Student {
      public string Name { get; set; }
      public int StuNum { get; set; }

      private int? grade = null;
      public int? Grade {
         get {
            if (this.grade == null) {
               Console.WriteLine("This student has non grade yet!");
            }
            return this.grade;
         }
         set {
            if (value >= 0 && value <= 100) {
               this.grade = value;
            }
         }
      }

      public Student(string name, int stuNum) {
         this.Name = name;

         if (stuNum < 0) {
            throw new Exception("Student number cannot be negative!");
         }

         this.StuNum = stuNum;
      }
   }


   class Program {
      static void Main(string[] args) {
         Student stu = new Student("Parsa", -235);

         Console.WriteLine("Name : " + stu.Name);
         Console.WriteLine("Student number : " + stu.StuNum);

         Console.WriteLine("Grade : " + stu.Grade);
         stu.Grade = 80;
         Console.WriteLine("Grade : " + stu.Grade);
         stu.Grade = 780;
         Console.WriteLine("Grade : " + stu.Grade);

      }
   }
}
