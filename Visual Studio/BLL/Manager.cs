using DAL;
using Model;
using System;
using System.Collections.Generic;

namespace BLL {
   public class Manager {
      public static void AddStudent(Student newStudent) {
         // check if student number is unique

         Services.AddStudentToDataStorage(newStudent);
      }

      public static List<Student> GetAllStudents() {
         return Services.GetAllStudentsFromDataStorage();
      }

      public static Student GetStudentById(int studentNumber) {
         return Services.GetStudentById(studentNumber);
      }
   }
}
