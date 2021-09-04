using System;

namespace _05___properties {
   class Student {
      private string name;

      // with a property
      public string Name {
         get {
            return this.name;
         }
         set {
           name = value;
         }
      }

      // old way
      public void SetName(string value) {
         this.name = value;
      }

      public string GetName() {
         return this.name;
      }

   }
   class Program {
      static void Main(string[] args) {
         Student stu = new Student();
         stu.Name = "toto";
         Console.WriteLine(stu.Name);

         stu.SetName("toto");
      }
   }
}