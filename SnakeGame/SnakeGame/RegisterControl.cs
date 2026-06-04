using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SnakeGame
{
    public partial class RegisterControl : UserControl
    {
        public RegisterControl()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(25, 25, 25);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            if(!NameTextBox.Text.Equals(""))
            {
                GameState.PlayerName = NameTextBox.Text;
                Form1.Instance.ChangeScreen(new MenuControl());
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
    }
}