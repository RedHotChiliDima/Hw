using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class MenuControl : UserControl
    {
        public MenuControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(25, 25, 25);
            HighScoreManager.LoadAndDisplayRecords(RecordList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Instance.ChangeScreen(new GameControl());
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {

        }

        private void RecordList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.Instance.Close();
        }
    }
}