using System;

namespace _06___interfaces {
   abstract class Device {
      public abstract void Use();
   }

   class Oven : Device {
      public override void Use() {
         Console.WriteLine("Cook something in the oven.");
      }
   }

   class Laptop : Device {
      public override void Use() {
         Console.WriteLine("Send an email with the Laptop.");
      }
      public void Charge() {
         Console.WriteLine("Laptop is charging");
      }
   }

   class CellPhone : Device {
      public override void Use() {
         Console.WriteLine("Watch a video on YouTube with the cellphone.");
      }
      public void Charge() {
         Console.WriteLine("Cellphone is charging");
      }
   }

   class Technicien {
      public void UseSomething(Device dev) {
         dev.Use();
      }
      public void ChargeSomething() {
      }
   }

   class Program {
      static void Main(string[] args) {
         Technicien tech = new Technicien();
         Oven oven = new Oven();
         tech.UseSomething(oven);
      }
   }
}
