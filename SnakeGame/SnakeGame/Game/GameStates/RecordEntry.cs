using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGame
{
    public class RecordEntry
    {
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public RecordEntry(string name, int score)
        {
            PlayerName = name;
            Score = score;
        }
        public override string ToString()
        {
            return $"{PlayerName} — {Score} очков";
        }
    }

    public static class HighScoreManager
    {
        private const string FileName = "highscores.txt";

        /// <summary>
        /// Записывает новый рекорд в файл.
        /// </summary>
        public static void SaveRecord(string playerName, int score)
        {
            try
            {
                string recordLine = $"{playerName}:{score}";

                File.AppendAllLines(FileName, new[] { recordLine });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось сохранить рекорд: {ex.Message}");
            }
        }

        /// <summary>
        /// Читает файл, сортирует по возрастанию очков и выводит результаты в ListBox.
        /// </summary>
        public static void LoadAndDisplayRecords(ListBox listBox)
        {
            // Очищаем ListBox перед новой загрузкой, чтобы рекорды не дублировались
            listBox.Items.Clear();

            // Если файла еще нет (первый запуск игры) — просто выходим
            if (!File.Exists(FileName))
            {
                listBox.Items.Add("не удалось загрузить рекорды");
                return;
            }

            try
            {
                List<RecordEntry> recordsList = new List<RecordEntry>();

                // Читаем файл построчно
                string[] lines = File.ReadAllLines(FileName);

                foreach (string line in lines)
                {
                    // Пропускаем пустые строки, если они случайно появились
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    // Разделяем строку по двоеточию
                    string[] parts = line.Split(':');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        // Пробуем безопасно перевести очки в число
                        if (int.TryParse(parts[1], out int score))
                        {
                            recordsList.Add(new RecordEntry(name, score));
                        }
                    }
                }

                // === МАГИЯ СОРТИРОВКИ ПО ВОЗРАСТАНИЮ ===
                // OrderBy сортирует от меньшего к большему (по возрастанию)
                // Если нужно по убыванию (топ лучших), то используется OrderByDescending
                var sortedRecords = recordsList.OrderByDescending(r => r.Score).ToList();

                // Загружаем отсортированные объекты прямо в ListBox
                foreach (var record in sortedRecords)
                {
                    listBox.Items.Add(record); // ListBox сам вызовет метод ToString(), который мы настроили выше
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении рекордов: {ex.Message}");
            }
        }
    }
}
