using System;

namespace Delegates {

   delegate void MyDG();

   class Program {
      static void MyFunction() {
         Console.WriteLine("Hi there!");
      }
      static void OtherFunction() {
         Console.WriteLine("Hola!");
      }

      static void Main(string[] args) {
         MyDG myDG = new MyDG(MyFunction);
         myDG += new MyDG(OtherFunction);
         myDG();
      }
   }
}




