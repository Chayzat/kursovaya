using kurs_proj.Pages;
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
using System.Windows.Shapes;

namespace kurs_proj
{
    /// <summary>
    /// Логика взаимодействия для main_user_win.xaml
    /// </summary>
    public partial class main_user_win : Window
    {
        public main_user_win()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void btn_news_user_Click(object sender, RoutedEventArgs e)
        {
            MainFrameUser.Navigate(new user_news());
        }

        private void btn_reports_user_Click(object sender, RoutedEventArgs e)
        {
            MainFrameUser.Navigate(new reports_page());
        }

        private void btn_merop_user_Click(object sender, RoutedEventArgs e)
        {
            MainFrameUser.Navigate(new user_meet());
        }

        private void btn_epm_user_Click(object sender, RoutedEventArgs e)
        {
            MainFrameUser.Navigate(new user_empl());
        }

        private void btn_partn_user_Click(object sender, RoutedEventArgs e)
        {
            MainFrameUser.Navigate(new user_partn());
        }

        private void btn_logout_user_Click(object sender, RoutedEventArgs e)
        {
            MainWindow logout = new MainWindow();
            logout.Show();
            this.Hide();
        }
    }
}
