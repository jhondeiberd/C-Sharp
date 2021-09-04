using System;

namespace _05___default_values_for_data_members {
   class Program {
      int integer;            // 0
      double floatingPoint;   // 0.0
      bool boolean;           //  false
      DateTime date;          // january 1st year 1 (12am)
      Program reference;      // null
      int? nullableInteger;

      static void Main(string[] args) {
         Program p = new Program();
         Console.WriteLine(p.integer);
         Console.WriteLine(p.floatingPoint);
         Console.WriteLine(p.boolean);
         Console.WriteLine(p.date);
         Console.WriteLine((object)p.reference ?? (object)"NULL!");
         Console.WriteLine((object)p.nullableInteger ?? (object)"NULL!");
      }
   }
}
