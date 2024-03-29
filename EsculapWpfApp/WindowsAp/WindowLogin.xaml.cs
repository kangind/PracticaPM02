﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using EsculapWpfApp.ModelBD;

namespace EsculapWpfApp.WindowsAp
{
    /// <summary>
    /// Логика взаимодействия для WindowLogin.xaml
    /// </summary>
    public partial class WindowLogin : Window
    {

        public static ModelBD.DataBase bd = new ModelBD.DataBase();
        public WindowLogin()
        {
            InitializeComponent();
            bd.users.Load();
            loginComboBox.ItemsSource = bd.users.Local;
        }

        public static string userMessage = "userError";

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {

            if (Auth(loginComboBox.Text, passwordBox.Password))
            {
                WindowControl main = new WindowControl();
                main.Show();
                this.Close();
            }
            else if (userMessage == "userError") MessageBox.Show("Выберите пользователя и введите пароль");
            else MessageBox.Show("Пользователь с такими данными не найден");
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }

        public void CloseWindow()
        {
            this.Close();
        }

        public static bool Auth(string login, string password)
        {
            if (login=="" || password=="")
            {
                return false;
            }
            using (var db = new DataBase())
                if (db.users.AsNoTracking().
                    FirstOrDefault(u =>u.password == password && u.login == login)!= null)
                {
                    return true;
                }
                else
                {
                    userMessage = "entitesError";
                    return false;
                }
        }
    }
}
