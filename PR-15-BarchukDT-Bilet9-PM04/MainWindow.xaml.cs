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

namespace PR_15_BarchukDT_Bilet9_PM04
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txt_login_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool isOk = LoginValidate(txt_login.Text);
            if (isOk == false)
            {
                tb_login.Text = "Неверное количество символов";
            }
            else
            {
                tb_login.Text = "Количество символов в порядке";
            }
        }

        private void txt_password_PasswordChanged(object sender, RoutedEventArgs e)
        {
            bool isOk = PasswordValidate(txt_password.Password);
            if (isOk == false)
            {
                tb_password.Text = "Неверное количество символов";
            }
            else
            {
                tb_password.Text = "Количество символов в порядке";
            }
        }

        public static bool PasswordValidate(string pass)
        {
            if (pass.Length < 10 || pass.Length > 100)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool LoginValidate(string log)
        {
            if (log.Length < 4 || log.Length > 35)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
