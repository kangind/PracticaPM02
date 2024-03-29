﻿using System;
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

namespace EsculapWpfApp.WindowsAp
{
    /// <summary>
    /// Логика взаимодействия для WindowDelete.xaml
    /// </summary>
    public partial class WindowDelete : Window
    {
        public WindowDelete()
        {
            InitializeComponent();
            textDelWindow.Text += WindowControl.selectEntites.TreatyID + " ?";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            WindowLogin.bd.Reception.Remove(WindowControl.selectEntites);
            WindowLogin.bd.SaveChanges();
            this.Close();
        }
    }
}
