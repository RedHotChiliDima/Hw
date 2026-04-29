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

namespace MultiWindowDemo
{
    public partial class OrderWindow : Window
    {
        public int FinalPrice { get; private set; } = 0;
        public OrderWindow(string name)
        {
            InitializeComponent();
            HelloTextBox.Text = $"Здравствуйте, {name}";
        }

        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            if (!((FirstCb.IsChecked==true) || (SecondCb.IsChecked == true) || (ThirdCb.IsChecked == true)))
            {
                MessageBox.Show("Выберите что-нибудь","");
            }
            else {
                DialogResult = true;
                Close();
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void CheckBox_Changed(object sender, RoutedEventArgs e)
        {
            int value = 0;
            if(sender is CheckBox cb && cb.Tag != null)
            {
                value = int.Parse(cb.Tag.ToString());
                if (cb.IsChecked == true)
                {
                    FinalPrice += value;
                }
                else
                {
                    FinalPrice -= value;
                }

            }
        }
    }
}
