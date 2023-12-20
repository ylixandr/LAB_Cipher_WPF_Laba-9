using System;
using System.Collections.Generic;
using System.IO;
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

namespace LAB_Cipher_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            User user = new User();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
        string login = Login.Text;
            string password1 = Password_1.Password;
            string password2 = Password_2.Password;

            if (password1 == password2)
            {
                // Выберите нужный шифр (ACipher, BCipher, CCipher) в зависимости от вашего выбора
                ACipher cipher = new ACipher(password1);

                // Устанавливаем логин, пароль и шифр в объект пользователя
                user.Login = login;
                user.Password = password1;
                user.Cipher = cipher;

                // Регистрируем пользователя
                user.Register();

                MessageBox.Show("Пользователь успешно зарегистрирован.");
            }
            else
            {
                MessageBox.Show("Пароли не совпадают.");
            }
        }
    
    }
}
