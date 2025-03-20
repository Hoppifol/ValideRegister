using ClassLibrary2;
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

namespace Autorization
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Aut_Click(object sender, RoutedEventArgs e)
        {
            String email = TextBox1.Text;
            String phone = TextBox2.Text;
            String password;
            password = PWBox.Password;

            bool emailValid = Class1.ValidateEmail(email);
            bool phoneValid = Class1.ValidatePhone(phone);
            bool passwordValid = Class1.ValidatePassword(password);

            if (emailValid & passwordValid & phoneValid)
            {
                MessageBox.Show("Ваш аккаунт был создан");
                MainWindow Window = new MainWindow();
                Window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данные введены неверно");
            }


        }
    }
}
