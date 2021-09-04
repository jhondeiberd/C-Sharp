using System;
using System.Collections;
using System.Collections.Generic;

namespace _08___examples {
   namespace StringNS {
      class Program {
         public static void Test() {
            string str = "toto";    // create a string
            Console.WriteLine(str.Length);   // length of the string
            Console.WriteLine(string.Empty);    // the empty string is ""

            string str1 = "toto", str2 = "titi";
            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str2.CompareTo(str1));

            string str3 = "toto";
            Console.WriteLine("str3 = " + str3);
            Console.WriteLine(str1.CompareTo(str3));
            if (str1 == str3) {
               Console.WriteLine("exact same string objets!");
            }
            else {
               Console.WriteLine("not same string objects");
            }

            string str4 = "tita";
            str4 = str4.Replace('i', 'o');
            str4 = str4.Replace('a', 'o') + "op";
            str4 = str4.Remove(4, 2);
            //str4 = Console.ReadLine();
            Console.WriteLine("str4 = " + str4);
            Console.WriteLine(str1.CompareTo(str4));
            if (str1 == str4) {
               Console.WriteLine("exact same string objets!");
            }
            else {
               Console.WriteLine("not same string objects");
            }

            // concatenation
            string str5 = "Hello ";
            string str6 = "world!";
            Console.WriteLine(str5 + str6);
            Console.WriteLine(string.Concat(str5, str6));

            // does a string contain another string
            string str7 = "Hi everybody";
            Console.WriteLine(str7.Contains("every"));
            Console.WriteLine(str7.Contains("all"));

            // split a string according to some separators characters
            string str8 = "    21312342       ,24345345;345345m34534534,5345345345;3535";
            string[] arrStr = str8.Split(',', ';');
            foreach (string s in arrStr) {
               Console.WriteLine("|" + s + "|");
            }

            Console.WriteLine("{0} + {1} = {2}", 34, 12, 46);
            string str9 = string.Format("{0} + {1} = {2}", 34, 12, 46);
            Console.WriteLine(str9);

            string str10 = "       some spaces      ";
            Console.WriteLine("raw string : |" + str10 + "|");
            Console.WriteLine("TrimStart : |" + str10.TrimStart() + "|");
            Console.WriteLine("TrimEnd : |" + str10.TrimEnd() + "|");
            Console.WriteLine("Trim : |" + str10.Trim() + "|");

            string str11 = "I am a string instance";
            Console.WriteLine(str11[7]);
         }
      }
   }

   namespace ArrayListNS {
      class Program {
         public static void PrintArrayList(ArrayList al) {
            Console.WriteLine("----------------------------------------------");
            foreach (object o in al) {
               Console.WriteLine(o);
            }
            Console.WriteLine("al.Count = " + al.Count);
            Console.WriteLine("al.Capacity = " + al.Capacity);
         }
         public static void Test() {
            ArrayList al = new ArrayList();
            Console.WriteLine("al.Count = " + al.Count);
            Console.WriteLine("al.Capacity = " + al.Capacity);
            al.Add(true);
            al.Add("toto");
            al.Add(3.14159);
            al.Add(new Program());
            al.Add(new int[] { 1, 2, 3, 4, 5 });

            PrintArrayList(al);

            al.Insert(1, 666);

            PrintArrayList(al);

            al.InsertRange(3, new int[] { 1, 2, 3, 4, 5 });

            PrintArrayList(al);

            al.Remove(666);

            //al.TrimToSize();

            PrintArrayList(al);

            al.Capacity = 12;

            PrintArrayList(al);

            try {
               al.Capacity = 8;
               PrintArrayList(al);
            }
            catch (NullReferenceException) {
               Console.WriteLine("Null pointer!!!");
            }
            catch (ArgumentOutOfRangeException aoore) {
               Console.WriteLine("can't change capacity, it's to low");
               Console.WriteLine(aoore.Message);
            }
            finally {

            }

            al[0] = "not true";
            PrintArrayList(al);

            al.Contains("toto");
         }
      }
   }

   namespace ListNS {
      class Program {
         public static void Test() {
            List<Student> students = new List<Student>();

            students.Add(new Student() { Name = "toto", StuNum = 12324 });
            students.Add(new Student() { Name = "Parsa", StuNum = 5232 });
            students.Add(new Student() { Name = "Rohit", StuNum = 1224 });

            foreach (Student student in students) {
               Console.WriteLine(student);
            }

            List<object> lo = new List<object>();
         }
      }

      internal class Student : Object {
         public string Name { get; set; }
         public int StuNum { get; set; }

         public override string ToString() {
            return string.Format("{0} ({1})", this.Name, this.StuNum);
         }
      }
   }

   namespace HashtableNS {
      class Program {
         public static void Test() {
            Hashtable ht = new Hashtable();

            ht.Add(45, true);
            ht.Add("toto", 12345);
            ht.Add(false, new Program());

            foreach (DictionaryEntry item in ht) {
               Console.WriteLine("key : {0} , value : {1}", item.Key, item.Value);
            }

            Console.WriteLine(ht.Count);
         }
      }
   }

   namespace DictionaryNS {
      class Program {
         public static void Test() {
            Dictionary<int, Student> students = new Dictionary<int, Student>();

            Student parsa = new Student() { Name = "Parsa", StuNum = 2111011 };
            students.Add(parsa.StuNum, parsa);
            Student hamza = new Student() { Name = "Hamza", StuNum = 1234455 };
            students.Add(hamza.StuNum, hamza);

            //students.Clear();

            Console.WriteLine("----------------------------------------");
            foreach (KeyValuePair<int, Student> item in students) {
               Console.WriteLine("stuNum = {0}, Student = {1}", item.Key, item.Value);
            }

            students.Remove(2111011);

            Console.WriteLine("----------------------------------------");
            foreach (KeyValuePair<int, Student> item in students) {
               Console.WriteLine("stuNum = {0}, Student = {1}", item.Key, item.Value);
            }

            Console.WriteLine(students[1234455]);


            object o1 = new object();
            object o2 = new object();
            object o3 = new object();
            object o4 = o1;

            Console.WriteLine(o1.GetHashCode());
            Console.WriteLine(o2.GetHashCode());
            Console.WriteLine(o3.GetHashCode());
            Console.WriteLine(o4.GetHashCode());
         }
      }
      internal class Student : Object {
         public string Name { get; set; }
         public int StuNum { get; set; }

         public override string ToString() {
            return string.Format("{0} ({1})", this.Name, this.StuNum);
         }
      }
   }

   class Program {
      static void Main(string[] args) {
         //String.Program.Test();
         //ArrayListNS.Program.Test();
         //ListNS.Program.Test();
         //HashtableNS.Program.Test();
         DictionaryNS.Program.Test();
      }
   }
}
