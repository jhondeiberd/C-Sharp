using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___examples {

   class Program {
      public void ComputeIntegers(int n1, int n2, out int sum, out int avg) {
         sum = n1 + n2;
         avg = sum / 2;
      }

      public static int sum(params int[] array) {
         Console.WriteLine("size of array is {0}", array.Length);
         int sum = 0;
         foreach (int n in array) {
            sum += n;
         }
         return sum;
      }
      static void Main(string[] args) {

         int[] anArray = { 1, 25, 3, 5, 3, 6, 8, 4, 2, 2 };
         Console.WriteLine(sum(anArray));

         Console.WriteLine(sum(1, 25, 3, 5, 3, 6, 8, 4, 2, 2));
         int n1 = 12, n2 = 90;
         Console.WriteLine(sum(n1, n2));

         Console.WriteLine(sum());

         Console.WriteLine("{0} + {1} = {2}", 1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
      }
   }
}
