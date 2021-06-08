using EsculapWpfApp.ModelBD;
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

namespace EsculapWpfApp.WindowsAp
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        public WindowAdd()
        {
            InitializeComponent();
            data.Doctors.Load();
            doctoridComboBox.ItemsSource = data.Doctors.Local;
            this.priceTextBox.PreviewTextInput += new TextCompositionEventHandler(priceTextBox_PreviewTextInput);

        }
        ModelBD.DataBase data = new DataBase();


        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            CloseWin();
        }

        void CloseWin()
        {
            WindowControl main = new WindowControl();
            main.Show();
            this.Close();
        }


        Reception recadd = new Reception();
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                recadd.Cost = Convert.ToDecimal(priceTextBox.Text);
            recadd.DateStart = (DateTime)datestartDatePicker.SelectedDate;
            recadd.TimeStart = timestartTextBox.Text;
            recadd.DoctorID = data.Doctors.Local.Where(x => x.FIO == doctoridComboBox.Text).FirstOrDefault().DoctorID;
                data.Reception.Add(recadd);
                data.SaveChanges();
                CloseWin();
            }
            catch (Exception)
            {

                MessageBox.Show("Ошибка в вводимых данных");
            }        
        
        }
        
        
        
        System.Text.RegularExpressions.Regex inputRegex = 
            new System.Text.RegularExpressions.Regex(@"[0-9]|,");
        private void priceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            System.Text.RegularExpressions.Match match = inputRegex.Match(e.Text);
            if (!match.Success)
            {
                e.Handled = true;
            }
        }
    }
}
