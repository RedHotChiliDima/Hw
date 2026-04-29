using System.Windows;

namespace MultiWindowDemo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void OpenProfileButton_Click(object sender, RoutedEventArgs e)
        {
            if(NameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите имя","Ошибка");
            }
            else
            {
                OrderWindow orderWindow = new OrderWindow(NameTextBox.Text);
                bool? result = orderWindow.ShowDialog();

                if (result == true)
                {
                    PriceLabel.Text = $"Цена заказа:{orderWindow.FinalPrice.ToString()} ";
                }
                else
                {
                    PriceLabel.Text = "Отмена заказа";
                }
            }
        }
    }
}