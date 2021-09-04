using System;

namespace _06___interfaces__full_example_in_class_ {
   class Laptop : ProgrammableDevice, DeviceWithBattery {
      public void Program() {
         Console.WriteLine("Programming the laptopd");
      }
      public void Charge() {
         Console.WriteLine("Laptop is charging...");
      }
   }

   class Desktop : ProgrammableDevice {
      public void Program() {
         Console.WriteLine("Programming the desktop");
      }
      public void Charge() { }
   }

   class Earphones : DeviceWithBattery {
      public void Charge() {
         Console.WriteLine("Earphones are charging...");
      }
   }

   interface DeviceWithBattery {
      void Charge();
   }

   interface ProgrammableDevice {
      void Program();
   }

   class Student {
      public void Program(ProgrammableDevice somethingToProgram) {
         somethingToProgram.Program();
      }
      public void Charge(DeviceWithBattery someDeviceWithBattery) {
         someDeviceWithBattery.Charge();
      }
   }

   class Program {
      static void Main(string[] args) {
         Student stu = new Student();
         Laptop comp = new Laptop();
         Desktop myDesktop = new Desktop();
         Earphones myEarphones = new Earphones();
         stu.Program(comp);
         stu.Program(myDesktop);
         stu.Charge(comp);
         stu.Charge(myEarphones);
      }
   }
}
