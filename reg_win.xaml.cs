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
using System.Data.SqlClient;
using Microsoft.Win32;
using System.IO;

namespace kurs_proj
{
    /// <summary>
    /// Логика взаимодействия для reg_win.xaml
    /// </summary>
    public partial class reg_win : Window
    {
        string connectionString= @"Data Source=LAPTOP-4F2BDOND\SQLEXPRESS;Initial Catalog=icc;Integrated Security=True";
        public reg_win()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Hide();
        }
        private void tb_name_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_name.Text = "";
        }
        private void tb_first_name_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_first_name.Text = "";
        }
        private void tb_last_name_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_last_name.Text = "";
        }
        private void tb_post_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_post.Text = "";
        }
        private void tb_email_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_email.Text = "";
        }
        string imgLoc = "";
        private void btn_photo_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg)|*.jpg|(*.png)|*.png| All files(*.*)|*.*";
            if (ofd.ShowDialog() == true)
            {
                imgLoc = ofd.FileName.ToString();
                photo.Source=new BitmapImage(new Uri(imgLoc));
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text == "" || tb_first_name.Text == "" || tb_post.Text == "" || tb_email.Text == "" || ps_1.Password == "" || ps_2.Password == "")
            {
                MessageBox.Show("Заполните все обязательные поля(*)!");
            }
            else
                if (ps_1.Password != ps_2.Password)
                MessageBox.Show("Повторно введите пароль!");
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    byte[] images = null;
                    FileStream Streem = new FileStream(imgLoc,FileMode.Open,FileAccess.Read);
                    BinaryReader brs = new BinaryReader(Streem);
                    images = brs.ReadBytes((int)Streem.Length);
                    sqlCon.Open();
                    string str = "INSERT INTO emps(ID_employee, first_name_emp, name_emp, last_name_emp, birth_emp,gender_emp,post_emp, email_emp, passw_emp, photo_prof) VALUES ('"+ID.Text
                        +"','"+tb_first_name.Text+"','"+tb_name.Text+"','"+tb_last_name.Text+"','"+dp_birth.SelectedDate+"','"+gender.Text+"','"+tb_post.Text+
                        "','"+tb_email.Text+"','"+ps_1.Password+"',@images)";
                    SqlCommand comm = new SqlCommand(str,sqlCon);
                    comm.Parameters.Add(new SqlParameter ("@images", images));
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                }
            }
        }
        private void gender_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
         
        }

        private void ID_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ID.Text = "";
        }

        private void gender_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            gender.Text = "";
        }
    }
}
