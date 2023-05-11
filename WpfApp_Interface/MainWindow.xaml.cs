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
using Microsoft.EntityFrameworkCore;

namespace WpfApp_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textbox_login.Text.Trim();
            string pass = passbox_password.Password.Trim();
            string verify_pass = passbox_password_verify.Password.Trim();
            string email = textbox_email.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textbox_login.ToolTip = "Логин должен иметь хотя бы 5 символов!";
                textbox_login.Background = Brushes.Purple;
            }
            else if (pass.Length < 5)
            {
                passbox_password.ToolTip = "Слишком короткий пароль! Придумайте посложнее!";
                passbox_password.Background = Brushes.Purple;
            }
            else if (verify_pass != pass)
            {
                passbox_password_verify.ToolTip = "Пароли должны совпадать!";
                passbox_password_verify.Background = Brushes.Purple;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textbox_email.ToolTip = "Некорректный адрес электронной почты!";
                textbox_email.Background = Brushes.Purple;
            }
            else
            {
                textbox_login.ToolTip = "";
                textbox_login.Background = Brushes.Transparent;
                passbox_password.ToolTip = "";
                passbox_password.Background = Brushes.Transparent;
                passbox_password_verify.ToolTip = "";
                passbox_password_verify.Background = Brushes.Transparent;
                textbox_email.ToolTip = "";
                textbox_email.Background = Brushes.Transparent;

                MessageBox.Show("Все хорошо!");
            }
        }
    }
}
