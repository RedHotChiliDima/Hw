using System.Data;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using System.Windows.Threading;
using TaskPlanner.Models;
namespace TaskPlanner.ViewModels
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object?> _execute;
        private readonly Func<object?, bool>? _canExecute;
        public RelayCommand(Action<object?> execute, Func<object?, bool>?
       canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public bool CanExecute(object? p) => _canExecute?.Invoke(p) ??
       true;
        public void Execute(object? p) => _execute(p);
        public event EventHandler? CanExecuteChanged;
        public void RaiseCanExecuteChanged() =>
        CanExecuteChanged?.Invoke(this, EventArgs.Empty);
    }
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly DispatcherTimer _timer;
        private string _currentTime = string.Empty;
        private string _newTaskTitle = string.Empty;
        private System.DateTime _newTaskDeadline = System.DateTime.Now.AddDays(1);
        public ObservableCollection<TaskItem> Tasks { get; } = new();
        public string CurrentTime
        {
            get => _currentTime;
            set
            {
                _currentTime = value;
                OnPropertyChanged(nameof(CurrentTime));
            }
        }
        public string NewTaskTitle
        {
            get => _newTaskTitle;
            set
            {
                _newTaskTitle = value;
                OnPropertyChanged(nameof(NewTaskTitle));
                AddTaskCommand.RaiseCanExecuteChanged();
            }
        }
        public System.DateTime NewTaskDeadline
        {
            get => _newTaskDeadline;
            set
            {
                _newTaskDeadline = value;
                OnPropertyChanged(nameof(NewTaskDeadline));
            }
        }
        public RelayCommand AddTaskCommand { get; }
        public RelayCommand<TaskItem> RemoveTaskCommand { get; }
        public RelayCommand<TaskItem> CompleteTaskCommand { get; }
        public MainViewModel()
        {
            AddTaskCommand = new RelayCommand(
            _ => AddTask(),
            _ => !string.IsNullOrWhiteSpace(NewTaskTitle)
            );
            RemoveTaskCommand = new RelayCommand<TaskItem>(
            task => Tasks.Remove(task)
            );
            CompleteTaskCommand = new RelayCommand<TaskItem>(task =>
            {
                task.IsCompleted = true;
                task.Refresh();
            });
            // Таймер обновления — каждую секунду
            _timer = new DispatcherTimer
            {
                Interval =
           TimeSpan.FromSeconds(1)
            };
            _timer.Tick += OnTimerTick;
            _timer.Start();
            UpdateCurrentTime();
            // Демо-данные
            Tasks.Add(new TaskItem
            {
                Title = "Сдать лабораторную работу",
                Deadline = System.DateTime.Now.AddHours(3)
            });
            Tasks.Add(new TaskItem
            {
                Title = "Купить продукты",
                Deadline = System.DateTime.Now.AddDays(2)
            });
            Tasks.Add(new TaskItem
            {
                Title = "Просроченная задача",
                Deadline = System.DateTime.Now.AddHours(-5)
            });
        }
        private void OnTimerTick(object? sender, EventArgs e)
        {
            UpdateCurrentTime();
            foreach (var task in Tasks)
                task.Refresh();
        }
        private void UpdateCurrentTime()
        {
            var culture = new System.Globalization.CultureInfo("ru-RU");
            CurrentTime = System.DateTime.Now.ToString("dddd, dd MMMM yyyy | HH:mm:ss", culture);
        }
        private void AddTask()
        {
            Tasks.Add(new TaskItem
            {
                Title = NewTaskTitle.Trim(),
                Deadline = NewTaskDeadline
            });
            NewTaskTitle = string.Empty;
            NewTaskDeadline = System.DateTime.Now.AddDays(1);
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new
       PropertyChangedEventArgs(name));
    }
    // Обобщённая версия RelayCommand<T>
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        public RelayCommand(Action<T> execute) => _execute = execute;
        public bool CanExecute(object? p) => true;
        public void Execute(object? p) { if (p is T t) _execute(t); }
        public event EventHandler? CanExecuteChanged;
    }
}