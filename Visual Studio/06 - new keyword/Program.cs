using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___new_keyword {
   class ClassA {
      public virtual void F() {
         Console.WriteLine("in ClassA.F()");
      }
   }

   class ClassB : ClassA {
      public void F() {
         Console.WriteLine("in ClassB.F()");
      }
   }

   class Program {
      static void Main(string[] args) {
         ClassA b = new ClassB();
         b.F();
      }
   }
}
