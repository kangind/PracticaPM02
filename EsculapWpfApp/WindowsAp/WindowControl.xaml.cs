using EsculapWpfApp.ModelBD;
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

namespace EsculapWpfApp.WindowsAp
{
    /// <summary>
    /// Логика взаимодействия для WindowControl.xaml
    /// </summary>
    public partial class WindowControl : Window
    {
        public WindowControl()
        {
            InitializeComponent();
        }

        public static Reception SelectEntites = new Reception();

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            WindowAdd main = new WindowAdd();
            main.Show();
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            WindowDelete main = new WindowDelete();
            main.Show();
            this.Close();
        }
    }    
}
