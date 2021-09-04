using System;

namespace _01___exercises {
   namespace Question1 {
      class Program {
         public static void Question1() {
            Console.Write("Enter a radius ? ");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Area : " + (Math.PI * radius * radius));
            Console.WriteLine("Area : {0}", Math.PI * radius * radius);

            Console.WriteLine("Perimeter : {0}", 2 * Math.PI * radius);
         }
      }
   }
   namespace Question2 {

   }
   namespace Question3 {

   }


   class Program {
      static void Main(string[] args) {
         Question1.Program.Question1();
      }
   }
}
