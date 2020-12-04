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

namespace kurs_proj
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void auth_btn_Click(object sender, RoutedEventArgs e)
        {
            auth_win open_rf = new auth_win();
            open_rf.Show();
            this.Hide();
        }

        private void reg_btn_Click(object sender, RoutedEventArgs e)
        {
            reg_win reg_start = new reg_win();
            reg_start.Show();
            this.Hide();
        }
    }
}
