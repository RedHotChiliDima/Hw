using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing.Text;
using System.Drawing;

namespace TextEditor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InstalledFontCollection installedFonts = new InstalledFontCollection();
            foreach (FontFamily font in installedFonts.Families)
            {
                FontComboBox.Items.Add(font.Name);
            }
            for(int i = 0;i<102;i = i + 2)
            {
                FontSizeComboBox.Items.Add(i);
            }
        }

        private void CleanButton_Click(object sender, RoutedEventArgs e)
        {
            MainTextBox.Text = string.Empty;
        }
        private void SafeButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                System.IO.File.WriteAllText(dialog.FileName, MainTextBox.Text);
            }
        }
        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (dialog.ShowDialog() == true)
            {
                string content = System.IO.File.ReadAllText(dialog.FileName);
                MainTextBox.Text = content;
            }
        }
        private void FontComboBox_Changed(object sender, EventArgs e)
        {
            MainTextBox.FontFamily = new System.Windows.Media.FontFamily(FontComboBox.SelectedItem.ToString());
        } 
        

        private void FontSizeComboBox_SelectionChanged_Changed(object sender, SelectionChangedEventArgs e)
        {
            MainTextBox.FontSize = Convert.ToDouble(FontSizeComboBox.SelectedItem);
        }
    }
}