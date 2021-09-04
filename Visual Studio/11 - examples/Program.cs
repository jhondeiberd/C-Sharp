using System;
using System.IO;

namespace _11___examples {
   class Program {
      public static void ReadFile(string path) {
         string[] lines = File.ReadAllLines(path);

         foreach (string line in lines) {
            Console.WriteLine(line);
         }
      }

      public static void WriteFile(string path, string[] linesToWrite) {
         File.WriteAllLines(path, linesToWrite);
      }

      public static void AppendFile(string path, string[] linesToAppend) {
         File.AppendAllLines(path, linesToAppend);
      }

      public static void RemoveThirdLineOfFile(string path) {
         string[] lines = File.ReadAllLines(path);
         string[] newLines = new string[lines.Length - 1];

         int j = 0;  // index in newLines
         for (int i = 0; i < lines.Length; i++) {
            if (i != 2) {
               newLines[j] = lines[i];
               j++;
            }
         }

         File.WriteAllLines(path, newLines);

         File.AppendAllText(path, "This\nis\nthe\nend!");
      }

      static void Main(string[] args) {
         ReadFile("../../Program.cs");    // going twice up in the directories

         string[] lines = new string[3] { "line 1", "line 2", "line 3" };
         WriteFile("../../test.txt", lines);

         string[] lines2 = { "Anuj", "Rohit", "Vamseedhar", "Luis" };
         WriteFile("C:/Users/sduval/Desktop/test.txt", lines2);

         AppendFile("../../test.txt", new string[2] { "toto", "titi" });

         RemoveThirdLineOfFile("../../test.txt");
      }
   }
}
