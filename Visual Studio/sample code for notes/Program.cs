using System;
using System.Data.SqlClient;

namespace sample_code_for_notes {
   public class Animal {
      public int Weight { get; set; }
      public Animal(int weight) {
         Weight = weight;
      }
      public void PrintWeight() {
         Console.WriteLine("Weight : {0}", this.Weight);
      }
   }

   class Dog : Animal {
      public string Name { get; set; }
      public Dog(string name, int weight) : base(weight) {
         this.Name = name;
      }
      public void PrintInfo() {
         base.PrintWeight();
         Console.WriteLine("Name : {0}", this.Name);
      }
   }

   class Program {
      static void Test(string[] args) {
         Animal animal1 = new Animal(62);    // no cast
         Dog dog1 = new Dog("Milou", 15);    // no cast

         Animal dog2 = new Dog("Rex", 9);    // upcast from Dog to Animal
         object obj = dog1;                  // upcast from Dog to Object

         Dog dog3 = (Dog)dog2;      // downcast from Animal to Dog (OK)
         Dog dog4 = (Dog)obj;       // downcast from Object to Dog (OK)
         Dog dog5 = (Dog)animal1;   // downcast from Animal to Dog (ERROR!)
      }
   }
}

namespace Interface {
   interface IRunnable {
      void Run();
   }

   class Person : IRunnable {
      public void Run() {
         Console.WriteLine("Person running");
      }
   }

   abstract class Animal : IRunnable {
      public abstract void Run();
   }

   class Monkey : Animal {
      public override void Run() {
         Console.WriteLine("Monkey running");
      }
   }

   class Student {
      public int id;
   }

   class Test {
      public static void MakeItRun(IRunnable whateverThatCanRun) {
         whateverThatCanRun.Run();

         SqlConnection conn = new SqlConnection();
         System.Data.ConnectionState cs = conn.State;

         int[] arr = new int[4];

#pragma warning disable CS0219 // Variable is assigned but its value is never used

         int i = 1;
         float f = 2.32f;
         decimal dec = 5.55m;
         DateTime date = DateTime.Now;

         //Student stu = new Student();
         //stu.id = 5;

         Student stu = null;

         int? n = null;

         DateTime? dateOfBirth = null;
      }
   }
}

namespace Polymorphisme {
   class Person {
      public string Name { get; set; }
      public int Age { get; set; }
      public virtual void SayHi() {
         Console.WriteLine("Person SayHi");
      }
   }

   class Chinese : Person {
      public override void SayHi() {
         Console.WriteLine("Nihao");
      }
   }

   class TestApp {
      static void Main(string[] args) {
         Person person1 = new Person();
         Person person2 = new Chinese();
         person1.SayHi();
         person2.SayHi();
      }
   }
}