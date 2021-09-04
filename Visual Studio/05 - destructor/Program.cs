using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___destructor {
   class Customer {
      public int Id { get; set; }
      public string Name { get; set; }

      ~Customer() {
         this.CloseConnection();
      }

      public void OpenConnection() {
         // opening some web connection
      }
      public void CloseConnection() {
         // opening some web connection
      }
   }

   class Program {
      static void Main(string[] args) {
         {
            Customer aCustomer = new Customer() {
               Name = "toto",
               Id = 235
            };
            aCustomer.OpenConnection();
            // use the connection
            //aCustomer.CloseConnection();
         }

      }
   }
}
