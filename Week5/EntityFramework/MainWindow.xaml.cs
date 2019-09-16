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

namespace EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_data_Click(object sender, RoutedEventArgs e)
        {
            foreach (var student in db.Students)
            {
                string temp = $"{student.LastName},{student.FirstName} ({student.StudentID}) likes {student.FavoriteColor}";
                lst_data.Items.Add(temp);
            }

        }
    }
}
