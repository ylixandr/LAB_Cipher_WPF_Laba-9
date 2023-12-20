// User.cs
using System;
using System.IO;
using System.Windows;

namespace LAB_Cipher_WPF
{
    public class User
    {
        private string login;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private ACipher cipher;
        public ACipher Cipher
        {
            get { return cipher; }
            set { cipher = value; }
        }

        public void Register()
        {
            // Проверка, существует ли пользователь с таким логином
            if (CheckIfUserExists(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует.");
                return;
            }

            // Реализация сохранения данных пользователя в файл
            // Шифрование пароля перед сохранением
            string encryptedPassword = cipher.Encode();

            // Запись в текстовый файл
            using (StreamWriter writer = new StreamWriter("users.txt", true))
            {
                writer.WriteLine($"Login: {login}, Encrypted Password: {encryptedPassword}");
            }

            MessageBox.Show("Пользователь успешно зарегистрирован.");
        }

        private bool CheckIfUserExists(string loginToCheck)
        {
            // Проверка, существует ли пользователь с заданным логином
            if (File.Exists("users.txt"))
            {
                using (StreamReader reader = new StreamReader("users.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Разбиваем строку на части по запятой
                        string[] parts = line.Split(',');

                        // Проверяем логин (первая часть после разделения)
                        if (parts.Length > 0 && parts[0].Trim().Equals($"Login: {loginToCheck}", StringComparison.OrdinalIgnoreCase))
                        {
                            return true; // Пользователь существует
                        }
                    }
                }
            }

            return false; // Пользователь не существует
        }
    }
}
