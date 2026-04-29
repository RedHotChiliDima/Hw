using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // Метод для получения чисел из текстовых полей
        private bool TryGetNumbers(out double first, out double second)
        {
            first = 0;
            second = 0;
            // Пытаемся преобразовать текст в числа
            if (!double.TryParse(FirstNumberTextBox.Text, out first))
            {
                MessageBox.Show("Введите корректное первое число!",
                "Ошибка ввода",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
                return false;
            }
            if (!double.TryParse(SecondNumberTextBox.Text, out second))
            {
                MessageBox.Show("Введите корректное второе число!",
                "Ошибка ввода",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
                return false;
            }
            return true;
        }
        // Обработчик кнопки сложения
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first + second;
                ResultTextBox.Text = result.ToString();
                AddToHistory(first, second, "+", result);
            }
        }
        // Обработчик кнопки вычитания
        private void SubtractButton_Click(object sender, RoutedEventArgs
       e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first - second;
                ResultTextBox.Text = result.ToString();
                AddToHistory(first, second, "-", result);
            }
        }
        // Обработчик кнопки умножения
        private void MultiplyButton_Click(object sender, RoutedEventArgs
       e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = first * second;
                ResultTextBox.Text = result.ToString();
                AddToHistory(first, second, "*", result);
            }
        }
        // Обработчик кнопки деления
        private void DivideButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                // Проверка деления на ноль
                if (second == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно!",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                    return;
                }
                double result = first / second;
                ResultTextBox.Text = result.ToString();
                AddToHistory(first, second, "/", result);
            }
        }
        // обработчик кнопки возведения числа в степень второго
        private void PowerButton_Click(object sender, RoutedEventArgs e)
        {
            if (TryGetNumbers(out double first, out double second))
            {
                double result = Math.Pow(first, second);
                ResultTextBox.Text = result.ToString();
                AddToHistory(first, second, "+", result);
            }
        }
        // обработчик кнопки корня из первого числа
        private void SquareRootButton_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(FirstNumberTextBox.Text, out double first))
            {
                MessageBox.Show("Введите корректное число!",
                "Ошибка ввода",
                MessageBoxButton.OK,
                MessageBoxImage.Warning);
            }
            else
            {
                if (first >= 0)
                {
                    SecondNumberTextBox.Text = string.Empty;
                    double result = Math.Sqrt(first);
                    ResultTextBox.Text = result.ToString();
                    AddToHistory(first, "sqrt", result);
                }
                else
                {
                    MessageBox.Show("",
                    "Ну нет",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                }
            }
        }

        // обработчик кнопки очистки истории
        private void ClearHistoryButton_Click(object sender, RoutedEventArgs e)
        {
            HistoryBox.Items.Clear();
        }

        // Обработчик кнопки очистки
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNumberTextBox.Text = string.Empty;
            SecondNumberTextBox.Text = string.Empty;
            ResultTextBox.Text = string.Empty;
        }

        // метод добавляющий операцию в историю
        private void AddToHistory(double first, double second, string operation, double result)
        {
            HistoryBox.Items.Add($"{first} {operation} {second} = {result}");
        }
        private void AddToHistory(double first, string operation, double result)
        {
            HistoryBox.Items.Add($"{first} {operation} = {result}");
        }

        // Обработка нажатия кнопки очистки
        private void ClearButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Z)
            {
                ClearButton_Click(this, new RoutedEventArgs());
                
                ClearHistoryButton_Click(this, new RoutedEventArgs());
            }
        }

    }
}