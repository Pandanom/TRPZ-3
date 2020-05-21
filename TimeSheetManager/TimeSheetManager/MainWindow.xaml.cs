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
using TimeSheetManager.Model;
using TimeSheetManager.ViewModel;

namespace TimeSheetManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var b = TableManager.createTable("qwe", new List<Column>(), Model.TableType.timesheet);
            DataGridBuilder qwe = new DataGridBuilder(b);
            qwe.CreateColumns(ref this.phonesGrid);
            //MessageBox.Show(qwe[0].ToString());
            //MessageBox.Show(qwe[2].ToString());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object a = "qwe";
            object b = 123;
            object c = DateTime.Now;
            l1.Content = a;
            l2.Content = b;
            l3.Content = c;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Startup.Start();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var name = UserInfo.getInstance().Name;
            l1.Content = name;
        }
    }
}
