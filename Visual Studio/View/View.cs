using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace View {
   public class View {
      private static void AdddStudent() {
         Student stu = new Student();

         Console.WriteLine("Enter data for a student :");

         Console.Write("  Name ? ");
         stu.Name = Console.ReadLine();

         Console.Write("  Age ? ");
         stu.Age = int.Parse(Console.ReadLine());

         Console.Write("  Student number ? ");
         stu.StuNum = int.Parse(Console.ReadLine());

         Manager.AddStudent(stu);
      }
      private static void DisplayAllStudents() {
         List<Student> students = Manager.GetAllStudents();
         for (int i = 0; i < students.Count; i++) {
            Console.WriteLine("Student {0} :", i + 1);
            Console.WriteLine("    Name : {0}", students[i].Name);
            Console.WriteLine("    Age : {0}", students[i].Age);
            Console.WriteLine("    # : {0}", students[i].StuNum);
         }
      }

      private static void LookForStudent() {
         Console.Write("What student number ? ");
         int studentNumber = int.Parse(Console.ReadLine());

         Student found = Manager.GetStudentById(studentNumber);

         Console.WriteLine("I found {0}", found);
      }

      public static void Main(string[] anujs) {
         bool exit = false;

         while (!exit) {
            Console.WriteLine("       M E N U");
            Console.WriteLine();
            Console.WriteLine("  1 - add a student");
            Console.WriteLine("  2 - list all students");
            Console.WriteLine("  3 - exit application");
            Console.WriteLine("  4 - look for a student");
            Console.WriteLine();
            Console.Write("What do you want to do ? ");

            int option = int.Parse(Console.ReadLine());
            switch (option) {
               case 1:
                  AdddStudent();
                  Console.Clear();
                  break;
               case 2:
                  DisplayAllStudents();
                  break;
               case 3:
                  exit = true;
                  break;
               case 4:
                  LookForStudent();
                  break;
               default:
                  Console.WriteLine("Option not implemented...");
                  Thread.Sleep(2000);
                  Console.Clear();
                  break;
            }
         }
      }


   }
}
