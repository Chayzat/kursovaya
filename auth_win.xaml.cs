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
using System.Security.Principal;
using System.Threading;
using System.Data.SqlClient;
using System.Data;

namespace kurs_proj
{
    /// <summary>
    /// Логика взаимодействия для auth_win.xaml
    /// </summary>
    public partial class auth_win : Window
    {
        public auth_win()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
          
        }
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void btn_login_Click(object sender, RoutedEventArgs e)
        {
            //
           SqlConnection sqlcon = new SqlConnection(@"Data Source=LAPTOP-4F2BDOND\SQLEXPRESS;Initial Catalog=icc;Integrated Security=True");
             sqlcon.Open();
            string query = "SELECT * FROM emps WHERE email_emp=@email_user AND passw_emp=@passw_user";
           
            SqlCommand sqlCmd = new SqlCommand(query, sqlcon);
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.Parameters.AddWithValue("@email_user", tb_email.Text);
            sqlCmd.Parameters.AddWithValue("@passw_user", pssw_box.Password);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            var accountsCount = (int)sqlCmd.ExecuteScalar();
            if (tb_email.Text == "" || pssw_box.Password == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            else
            {
                if (tb_email.Text == "admin@mail.ru" && pssw_box.Password == "admin")
                {
                    main_win main = new main_win();
                    main.label_user.Content = accountsCount.ToString();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    if (dtbl.Rows.Count == 1 && tb_email.Text != "admin@mail.ru" && pssw_box.Password != "admin")
                    {
                        main_user_win user_win = new main_user_win();
                        user_win.label_user_user.Content = accountsCount.ToString();
                        user_win.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Введите корректно почту или пароль!");
                    }
                }
            }
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow back = new MainWindow();
            back.Show();
            this.Hide();
        }

        private void tb_email_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void tb_email_MouseEnter(object sender, MouseEventArgs e)
        {
            if(tb_email.Text.Equals(@"email*"))
            {
                tb_email.Text = "";
            }
        }
        private void tb_email_Clicked(object sender,RoutedEventArgs e )
        {
            
        }

        private void tb_email_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            tb_email.Text = "";
        }

        private void tb_email_MouseLeave(object sender, MouseEventArgs e)
        {
            if (tb_email.Text.Equals(""))
            {
                tb_email.Text = @"email*";
            }
        }
    }
}
