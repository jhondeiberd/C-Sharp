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

namespace WPF_example {
   /// <summary>
   /// Interaction logic for MainWindow.xaml
   /// </summary>
   public partial class MainWindow : Window {
      public MainWindow() {
         InitializeComponent();

         this.cmbbox_list.Items.Add("Tomato");
         this.cmbbox_list.Items.Add("Banana");
         this.cmbbox_list.Items.Add("IcedCap");
         this.cmbbox_list.Items.Add("Strawberry");
         this.cmbbox_list.Items.Add("nothing");

         this.Top = 100;
         this.Left = -1000;
      }

      private void MyClick(object sender, RoutedEventArgs e) {
         Console.WriteLine("Hello World!");

         Button theButton = (Button)sender;
         theButton.Content = "PARSA!";

         this.lbl_comment.Content = "Button has been clicked!";

         // remove an event
         //this.btn_theButton.GotFocus -= GotFocus;
         //this.btn_theButton.MouseEnter -= MouseEnter;
         //this.btn_theButton.Click -= MyClick;

         /*MainWindow anotherWindow = new MainWindow();
         anotherWindow.Top = 100;
         anotherWindow.Left = -1000;
         anotherWindow.Show();*/

         Window1 window1 = new Window1();
         window1.Top = 100;
         window1.Left = -1000;
         window1.Show();
         this.Close();
      }

      private void GotFocus(object sender, RoutedEventArgs e) {
         //this.btn_theButton.Background = Brushes.Bisque;
      }

      private void MouseEnter(object sender, MouseEventArgs e) {
         this.btn_theButton.Background = Brushes.Blue;
      }

      private void SelectionChanged(object sender, SelectionChangedEventArgs e) {
         ComboBox myList = (ComboBox)sender;
         this.lbl_comment.Content = myList.SelectedItem;
      }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
