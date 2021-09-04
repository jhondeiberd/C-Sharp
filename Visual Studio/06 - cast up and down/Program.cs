using System;

namespace _06___cast_up_and_down {
   abstract class Instrument {
      public int Weight { get; set; }
      public string Color { get; set; }

      public Instrument(int weight) {
         this.Weight = weight;
         this.Color = "brown";
      }

      public Instrument(int weight, string color) {
         this.Weight = weight;
         this.Color = color;
      }

      public void Print() {
         Console.WriteLine("Weight : {0}", this.Weight);
      }

      public virtual void Play() {
      }
   }

   class Saxophon : Instrument {
      public int Type { get; set; }

      public Saxophon(int weight, int type, string color)
         : base(weight, color) {
         this.Type = type;
      }

      public void PrintInfo() {
         base.Print();
         Console.WriteLine("Type : {0}", this.Type);
      }

      public override void Play() {
         base.Play();
         Console.WriteLine("Saxo is playing");
      }
   }
   class Guitar : Instrument {
      public int NumOfStrings { get; set; }

      public Guitar(int weight, int numOfStrings) : base(weight) {

      }
      public override void Play() {
         Console.WriteLine("Guitar is playing");
      }
   }
   class Piano : Instrument {
      public int NumOfKeys { get; set; }


      public override void Play() {
         Console.WriteLine("Piano is playing");
      }
   }
   class Program {
      static void Main(string[] args) {
         // creation of the orchestra
         Instrument[] orchestra = new Instrument[5];
         Random rnd = new Random();
         for (int i = 0; i < orchestra.Length; i++) {
            int kind = rnd.Next() % 3;
            switch (kind) {
               case 0:
                  orchestra[i] = new Saxophon(3, 1);
                  break;
               case 1:
                  orchestra[i] = new Guitar();
                  break;
               case 2:
                  orchestra[i] = new Piano();
                  break;
            }
         }

         // Print informations about each instruments
         foreach (var instr in orchestra) {

            if (instr is Piano) {
               Console.WriteLine("Piano : {0} keys.", ((Piano)instr).NumOfKeys);
            }
            else if (instr is Saxophon) {
               Saxophon sax = ((Saxophon)instr);
               Console.WriteLine("Saxo : type is {0} ", sax.Type);
               sax.PrintInfo();

            }
            else {
               Console.WriteLine("Guitar : {0} strings.", ((Guitar)instr).NumOfStrings);
            }
         }

         // Make the orchestra play
         Console.WriteLine("----------- foreach loop ------------");
         foreach (var instr in orchestra) {
            instr.Play();
         }

         Console.WriteLine("----------- for loop ------------");
         for (int i = 0; i < orchestra.Length; i++) {
            orchestra[i].Play();
         }         
      }
   }
}
