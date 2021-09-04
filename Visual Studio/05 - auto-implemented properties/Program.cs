using System;

namespace _05___auto_implemented_properties {
   class Program {
      public string FirstName { get; set; }
      public string LastName { get; set; }

      static void Main(string[] args) {
         Program p = new Program();
         p.FirstName = "Stephane";
         p.LastName = "Duval";
      }
   }
}
