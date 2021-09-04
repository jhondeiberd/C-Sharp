
namespace Model {
   public class Student {
      public int StuNum { get; set; }
      public string Name { get; set; }
      public int Age { get; set; }

      public override string ToString() {
         return string.Format("{0} ({1} yo, #{2})", this.Name, this.Age, this.StuNum);
      }
   }
}
