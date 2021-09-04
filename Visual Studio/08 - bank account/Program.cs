using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08___bank_account {
   class Person {
      public string Name { get; set; }

      public override string ToString() {
         return this.Name;
      }
   }


   class BankAccount {
      public int AccountNumber { get; set; }
      public double Amount { get; set; }

      public override string ToString() {
         return string.Format("{0} ({1}$)", this.AccountNumber, this.Amount);
      }
   }
   class Program {
      static void Main(string[] args) {
         Person toto = new Person { Name = "Toto" };
         Person parsa = new Person { Name = "Parsa" };

         Dictionary<Person, BankAccount> dict1 = new Dictionary<Person, BankAccount>() {
            {toto, new BankAccount { AccountNumber = 1324, Amount = 10000 } },
            {parsa, new BankAccount { AccountNumber = 34512, Amount = 500000 } }
         };

         dict1.Add(toto, new BankAccount { AccountNumber = 1324, Amount = 10000 });
         dict1.Add(parsa, new BankAccount { AccountNumber = 34512, Amount = 500000 });

         foreach (var item in dict1) {
            Console.WriteLine(item.Key + " / " + item.Value);
         }

         Console.WriteLine("Parsa account : {0}", dict1[parsa]);
         Console.WriteLine("just for a try : {0}", dict1[new Person { Name = "Parsa" }]);
      }
   }
}
