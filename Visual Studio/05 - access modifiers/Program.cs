using System;
using _05___access_modifiers;

namespace _05___access_modifiers {
   public class Program {
      public int publicDM;
      internal int internalDM;
      private int privateDM;

      static void Main(string[] args) {
         Program p = new Program();
         p.privateDM = 90;
         p.internalDM = 78;
         p.publicDM = 34;
      }
   }

}
namespace MyNameSpace {
   class AnotherClass {
      public static void F() {
         Program p = new Program();
         p.publicDM = 647;
         p.internalDM = 2354;
      }
   }
}


