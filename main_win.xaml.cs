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
using kurs_proj.Pages;
namespace kurs_proj
{
    /// <summary>
    /// Логика взаимодействия для main_win.xaml
    /// </summary>
    public partial class main_win : Window
    {
        public main_win()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
          //  MessageBox.Show("welcome - " + currentUser.name_user + currentUser.fname_user);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logout = new MainWindow();
            logout.Show();
            this.Hide();
        }

        private void btn_news_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new news_page());
        }

        private void btn_reports_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new reports_page());
        }

        private void btn_merop_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new meets_page());
        }

        private void btn_epm_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new employees_page());
        }

        private void btn_partn_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new partners_page());
        }

      

       
    }
}
