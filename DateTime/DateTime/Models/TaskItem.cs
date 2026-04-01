using System;
using System.ComponentModel;
namespace TaskPlanner.Models
{
    public class TaskItem : INotifyPropertyChanged
    {
        private string _title = string.Empty;
        private System.DateTime _deadline;
        private bool _isCompleted;
        public string Title
        {
            get => _title;
            set { _title = value; OnPropertyChanged(nameof(Title)); }
        }
        public System.DateTime Deadline
        {
            get => _deadline;
            set
            {
                _deadline = value;
                OnPropertyChanged(nameof(Deadline));
                OnPropertyChanged(nameof(TimeLeft));
                OnPropertyChanged(nameof(IsOverdue));
                OnPropertyChanged(nameof(DeadlineFormatted));
                OnPropertyChanged(nameof(TimeLeftFormatted));
            }
        }
        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }
        // --- Вычисляемые свойства на основе дата/время ---
        /// <summary>Оставшееся время до дедлайна</summary>
        public TimeSpan TimeLeft => Deadline - System.DateTime.Now;
        /// <summary>Задача просрочена?</summary>
        public bool IsOverdue => System.DateTime.Now > Deadline && !IsCompleted;
        /// <summary>Дедлайн в читаемом формате</summary>
        public string DeadlineFormatted =>
        Deadline.ToString("dd MMMM yyyy, HH:mm",
        new System.Globalization.CultureInfo("ru-RU"));

 public string TimeLeftFormatted
        {
            get
            {
                if (IsCompleted) return "Выполнено";
                var span = TimeLeft;
                if (span.TotalSeconds <= 0) return "ПРОСРОЧЕНО";
                if (span.TotalDays >= 1)
                    return $"{(int)span.TotalDays} д. {span.Hours} ч.{ span.Minutes}мин.";
            if (span.TotalHours >= 1)
                    return $"{span.Hours} ч. {span.Minutes} мин.";
                return $"{span.Minutes} мин. {span.Seconds} сек.";
            }
        }
        public void Refresh()
        {
            OnPropertyChanged(nameof(TimeLeft));
            OnPropertyChanged(nameof(IsOverdue));
            OnPropertyChanged(nameof(TimeLeftFormatted));
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new
       PropertyChangedEventArgs(name));
    }
}