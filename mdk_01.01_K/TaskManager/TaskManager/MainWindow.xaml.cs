using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TaskManager
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if(TaskTextBox.Text == string.Empty)
            {
                MessageBox.Show("Введите задачу","Ошибка",MessageBoxButton.OK);
            }
            else
            {
                TaskList.Items.Add(new TextBlock { Text = TaskTextBox.Text , FontSize = 16 });
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            TaskList.Items.Remove(TaskList.SelectedItem);
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            TaskList.Items.Clear();
        }

        private void TaskDoneButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskList.SelectedItem as TextBlock;
            if (task != null)
            {
                task.TextDecorations = TextDecorations.Strikethrough;
            }
        }

        private void TaskUnDoneButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskList.SelectedItem as TextBlock;
            if (task != null)
            {
                task.TextDecorations = null;
            }
        }
    }
}