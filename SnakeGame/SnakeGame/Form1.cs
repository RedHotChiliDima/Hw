using System.Windows.Forms;
using System.Drawing;

namespace SnakeGame
{
    public partial class Form1 : Form
    {
        public static Form1 Instance { get; private set; }

        public Form1()
        {
            InitializeComponent();
            Instance = this;

            this.Text = "Змейко";
            this.ClientSize = new Size(640, 420);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            ChangeScreen(new RegisterControl());
        }
        public void ChangeScreen(UserControl newScreen)
        {
            this.Controls.Clear();

            newScreen.Dock = DockStyle.Fill;

            this.Controls.Add(newScreen);

            newScreen.Focus();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
