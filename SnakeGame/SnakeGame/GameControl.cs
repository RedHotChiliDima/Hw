using SnakeGame.Game;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class GameControl : UserControl
    {
        private const int CellSize = 20;
        private const int FieldWidth = 29;
        private const int FieldHeight = 17;

        private const int OffsetX = 20;
        private const int OffsetY = 15;

        private GameTicker gameTicker;
        private Timer gameTimer;

        public GameControl()
        {
            InitializeComponent();

            this.Size = new Size(640, 420);

            gameTicker = new GameTicker(FieldWidth, FieldHeight);

            this.DoubleBuffered = true;
            this.BackColor = Color.FromArgb(25, 25, 25);

            this.Paint += OnGamePaint;
            this.KeyDown += OnGameKeyDown;

            gameTimer = new Timer();
            gameTimer.Interval = 200;
            gameTimer.Tick += GameTimer_Tick;

            this.TabStop = true;

            StartGame();
        }

        private void StartGame()
        {
            gameTimer.Start();
            this.Focus();
        }

        // --- ИГРОВОЙ ЦИКЛ (ТИК ТАЙМЕРА) ---
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            gameTicker.MakeTick();

            if (gameTicker.IsGameOver)
            {
                gameTimer.Stop();
                MessageBox.Show($"Игра окончена!\nВаш счет: {gameTicker.score}", "Game Over");

                HighScoreManager.SaveRecord(GameState.PlayerName, gameTicker.score);

                // Возврат в главное меню через глобальный экземпляр формы
                Form1.Instance.ChangeScreen(new MenuControl());
                return;
            }

            this.Invalidate();
        }

        // --- ОБРАБОТКА КЛАВИАТУРЫ ---
        private void OnGameKeyDown(object sender, KeyEventArgs e)
        {
            gameTicker.HandleInput(e.KeyCode);
        }

        // --- ОТРИСОВКА ВСЕЙ ГРАФИКИ ---
        private void OnGamePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int boardWidthInPixels = FieldWidth * CellSize;
            int boardHeightInPixels = FieldHeight * CellSize;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            using (Pen gridPen = new Pen(Color.FromArgb(35, 35, 35), 1))
            {
                for (int x = 0; x <= FieldWidth; x++)
                    g.DrawLine(gridPen, OffsetX + x * CellSize, OffsetY, OffsetX + x * CellSize, OffsetY + boardHeightInPixels);

                for (int y = 0; y <= FieldHeight; y++)
                    g.DrawLine(gridPen, OffsetX, OffsetY + y * CellSize, OffsetX + boardWidthInPixels, OffsetY + y * CellSize);
            }

            using (Pen borderPen = new Pen(Color.White, 2))
            {
                g.DrawRectangle(borderPen, OffsetX, OffsetY, boardWidthInPixels, boardHeightInPixels);
            }

            Point foodPos = gameTicker.Food;
            g.FillEllipse(Brushes.Crimson,
                OffsetX + foodPos.X * CellSize + 1,
                OffsetY + foodPos.Y * CellSize + 1,
                CellSize - 2,
                CellSize - 2);

            SnakeNode current = gameTicker.Snake.Head;
            while (current != null)
            {
                Brush color = (current == gameTicker.Snake.Head) ? Brushes.DarkGreen : Brushes.ForestGreen;

                g.FillRectangle(color,
                    OffsetX + current.Position.X * CellSize + 1,
                    OffsetY + current.Position.Y * CellSize + 1,
                    CellSize - 2,
                    CellSize - 2);

                current = current.Next;
            }

            // 5. ИНТЕРФЕЙС ИГРОКА (Выводим в правом верхнем углу, в свободном месте внутри отступа)
            string uiText = $"{GameState.PlayerName} | Счёт: {gameTicker.score}";

            // Чтобы текст не наезжал на рамку, выравниваем его по правому краю игрового поля
            Font uiFont = new Font("Arial", 10, FontStyle.Bold);
            SizeF textSize = g.MeasureString(uiText, uiFont);
            float textX = (OffsetX + boardWidthInPixels) - textSize.Width - 5;

            // Задняя черная подложка под текст, чтобы сетка его не перечеркивала
            g.FillRectangle(new SolidBrush(Color.FromArgb(25, 25, 25)), textX, 2, textSize.Width, textSize.Height);
            g.DrawString(uiText, uiFont, Brushes.White, textX, 2);
        }

        // ВАЖНО: Перехватываем стрелочки у Windows Forms
        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                    return true;
            }
            return base.IsInputKey(keyData);
        }
    }
}
