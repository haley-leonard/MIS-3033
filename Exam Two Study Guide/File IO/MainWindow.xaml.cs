using Microsoft.Win32;
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
using System.IO;

namespace File_IO
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "C:\\Users\\Haley\\Source\\Repos\\haley-leonard\\MIS-3033\\Exam Two Study Guide\\File IO\\bin\\Debug";
        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists(path))
            {
                StringReader sr = new StringReader(path);
            }
        }

        private void SalaryBTN_Click(object sender, RoutedEventArgs e)
        {
            Employees empSal = new Employees();
            string[] line = File.ReadAllLines(path);

            List<Employees> emp = new List<Employees>();
            for (int i=1;i<line.Length;i++)
            {
                Employees empl = new Employees();
                var file = line[i].Split('|');
                empl.firstName = file[0];
                empl.lastName = file[1];
                empl.email = file[2];
                empl.gender = file[3];
                empl.salary = Convert.ToDouble(file[4]);
            }
        }

        private void SelectFileBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
