using System.IO;

namespace Files {
   class Program {
      public static void ReadFile(string filePath) {

         string[] lines = File.ReadAllLines(filePath);
         foreach (string line in lines) {
            System.Console.WriteLine(line);
         }

         string allTextlines = File.ReadAllText(filePath);
         System.Console.WriteLine(allTextlines);

      }

      public static void WriteFile(string filePath) {

         File.WriteAllText(filePath, "this is some text");

         string[] lines = { "line 1", "line 2", "line 3" };
         File.WriteAllLines(filePath, lines);

      }

      public static void AppendFile(string filePath) {

         File.AppendAllText(filePath, "\nthis is another test");

         string[] lines = { "line 1", "line 2", "line 3" };
         File.AppendAllLines(filePath, lines);

      }
      static void Main(string[] args) {
         string programFile = "../../program.cs";
         ReadFile(programFile);

         string textFile = "../../file.txt";
         WriteFile(textFile);
         ReadFile(textFile);
         AppendFile(textFile);
         ReadFile(textFile);
      }
   }
}
