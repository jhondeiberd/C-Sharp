using Model;
using System.Collections.Generic;
using System.IO;

namespace DAL {
   public static class Services {
      public static string filePath = "../../students.txt";

      public static void AddStudentToDataStorage(Student stuToAdd) {
         string str = string.Format("{0},{1},{2}\n", stuToAdd.StuNum, stuToAdd.Name, stuToAdd.Age);
         File.AppendAllText(filePath, str);
      }

      public static List<Student> GetAllStudentsFromDataStorage() {
         List<Student> students = new List<Student>();
         try {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
               string[] data = line.Split(',');
               students.Add(new Student {
                  StuNum = int.Parse(data[0]),
                  Name = data[1],
                  Age = int.Parse(data[2])
               });
            }
         }
         catch (FileNotFoundException) {

         }
         return students;
      }

      public static Student GetStudentById(int studentNumber) {
         Student foundStudent = null;

         string[] lines = File.ReadAllLines(filePath);
         foreach (string line in lines) {
            string[] data = line.Split(',');
            if (int.Parse(data[0]) == studentNumber) {
               foundStudent = new Student {
                  StuNum = int.Parse(data[0]),
                  Name = data[1],
                  Age = int.Parse(data[2])
               };
               break;
            }
         }

         return foundStudent;
      }
   }
}
