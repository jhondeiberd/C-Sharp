using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View__WPF_ {
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window {
      public MainWindow() {
         InitializeComponent();

         List<Student> students = Manager.GetAllStudents();
         foreach (Student stu in students) {
            this.cmbBox_students.Items.Add(stu);
         }

         this.txtbox_text.Text = "Try";
         this.cmbBox_students.Items.Add(this.txtbox_text.Text);
      }

        private void cmbBox_students_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
