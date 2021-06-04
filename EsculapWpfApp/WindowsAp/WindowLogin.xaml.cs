using System;
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

        public static DataBase bd = new DataBase();


        
        public WindowLogin()
        {
            InitializeComponent();
            
        }

        private void enterButton_Click(object sender, RoutedEventArgs e)
        {
            WindowControl main = new WindowControl();
            main.Show();
            this.Close();

            
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            CloseWindow();
        }

        public void CloseWindow()
        {
            this.Close();
        }
    }
}
