using System;

namespace _06___quiz_question_about_ToString {
   interface IMovable {
      void Move();
   }
   abstract class Animal : IMovable {
      public abstract void Move();

   }
   abstract class Mammals : Animal {
   }


   class Student : object {
      public string Name { get; set; }
      public int Age { get; set; }

      public event EventHandler MyEvent;

      public void F() {
         this.MyEvent = null;
      }
      public override string ToString() {
         return string.Format("{2} - {0} ({1} years old)", this.Name, this.Age, Program.name);
         //return this.Name + " (" + this.Age + " years old)";
      }
   }
   class Program {
      public static string name = "anand";

      static void Main(string[] args) {
         Student aStudent = new Student { Name = "toto", Age = 26 };
         Program.name = "Rohith";
         Console.WriteLine(aStudent);
      }
   }
}
