using System;
namespace Observer_pattern {
   namespace Version1 {
      delegate void DGAlarm();
      class Dog {
         public DGAlarm alarmOn;

         public void AlarmOn() {
            // warn the owner
            this.alarmOn?.Invoke();
         }
      }
      class Owner {
         public string Name { get; set; }

         public Owner(string name, Dog dog) {
            this.Name = name;
            dog.alarmOn += this.HostAlarmOnHandler;
         }

         public Owner(string name) {
            this.Name = name;
         }

         public void HostAlarmOnHandler() {
            Console.WriteLine("{0} : Dog is smelling something strange", this.Name);
         }
      }

      class Program {
         public static void Test() {
            Owner somebody = new Owner("toto");
            Dog milou = new Dog();
            milou.alarmOn += somebody.HostAlarmOnHandler;
            milou.AlarmOn();
         }
      }
   }

   namespace Version2 {
      delegate void DGAlarm();
      class Dog {
         private DGAlarm alarmOn;

         public void AddAlarmOnEventHandler(DGAlarm job) {
            this.alarmOn += job;
         }

         public void RemoveAlarmOnEventHandler(DGAlarm job) {
            this.alarmOn -= job;
         }

         public void AlarmOn() {
            // warn the owner
            this.alarmOn?.Invoke();
         }
      }
      class Owner {
         public string Name { get; set; }
         public Owner(string name, Dog dog) {
            this.Name = name;
            //dog.alarmOn += this.HostAlarmOnHandler;
            //dog.addAlarmOnEventHandler(new DGAlarm(this.HostAlarmOnHandler));    // OR
            dog.AddAlarmOnEventHandler(this.HostAlarmOnHandler);
         }
         public void HostAlarmOnHandler() {
            Console.WriteLine("{0} : Dog is smelling something strange", this.Name);
         }
      }

      class Program {
         public static void Test() {
            Dog milou = new Dog();
            Owner tintin = new Owner("Tintin", milou);
            Owner tournesol = new Owner("Tournesol", milou);

            milou.RemoveAlarmOnEventHandler(new Owner("", milou).HostAlarmOnHandler);

            //milou.alarmOn = Test;    // we have to avoid that at all cost!
            milou.AlarmOn();
         }
      }
   }

   namespace Version3 {
      delegate void DGAlarm();
      class Dog {
         public event DGAlarm AlarmOnEvt;

         public void AlarmOn() {
            // warn the owner
            this.AlarmOnEvt?.Invoke();
         }
      }
      class Owner {
         public string Name { get; set; }
         public Owner(string name, Dog dog) {
            this.Name = name;
            dog.AlarmOnEvt += this.HostAlarmOnHandler;
         }
         public void HostAlarmOnHandler() {
            Console.WriteLine("{0} : Dog is smelling something strange", this.Name);
         }
      }

      class Program {
         public static void Test() {
            Dog milou = new Dog();
            Owner tintin = new Owner("Tintin", milou);
            Owner tournesol = new Owner("Tournesol", milou);

            milou.AlarmOnEvt -= tintin.HostAlarmOnHandler;
            // milou.AlarmOnEvt = null;   // not allowed!

            milou.AlarmOn();
         }
      }
   }

   class Program {
      static void Main(string[] args) {
         Version1.Program.Test();
         //Version2.Program.Test();
         //Version3.Program.Test();
      }
   }
}
