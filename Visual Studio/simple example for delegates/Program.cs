using System;

namespace simple_example_for_delegates {
   namespace Simple {
      delegate void DGTest();
      class Program {
         static void F() {
            Console.WriteLine("Hello world!");
         }
         static void B() {
            Console.WriteLine("Hola todos!");
         }
         public static void Test() {
            //F();
            DGTest test = F; // new DGTest(F);         
            test += B;
            test.Invoke();
            test -= F;
            test.Invoke();

            DGTest test1 = B;      // doing new DGTest(B); actually...
         }
      }
   }

   namespace Average {
      delegate void DGPrint(string str);

      class Program {
         private static void Print(string aString) {
            Console.WriteLine("in Print : " + aString);
         }
         private static void Write(string aString) {
            Console.WriteLine("in Write : " + aString);
         }
         public static void Test() {
            DGPrint anuj = new DGPrint(Write);
            anuj += Print;

            anuj.Invoke("Bonjour");
         }
      }
   }

   namespace Calculator {
      delegate int DGOperation(int a, int b);

      class Computer {
         public int Add(int a, int b) {
            return a + b;
         }
         public static int Sub(int a, int b) {
            return a - b;
         }

         public static DGOperation GetOperation(char op) {
            DGOperation theOp = null;
            switch (op) {
               case '+':
                  theOp = new DGOperation(new Computer().Add);
                  break;
               case '-':
                  theOp = Sub;
                  break;
            }
            return theOp;
         }

         public static void Test() {
            DGOperation op = GetOperation('-');
            //Console.WriteLine(op.Invoke(5, 7));
            Console.WriteLine(op(5, 7));
         }
      }
   }
   class Program {
      static void Main(string[] args) {
         //Simple.Program.Test();
         //Average.Program.Test();
         Calculator.Computer.Test();
      }
   }
}
