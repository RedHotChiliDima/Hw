namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] allLines = File.ReadAllLines("first.txt");
            foreach (string line in allLines)
            {
                comboBox1.Items.Add(line);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox1.Text == "")
            {
                label4.Text = "¬ведите все пол€";
            }
            else
            {
                label4.Text = "";
                String name = textBox1.Text;
                String school_class = comboBox1.Text;

                Form2 form2 = new Form2();
                Form1 form1 = this;
                form1.Visible = false;
                form2.ShowDialog();
                form1.Visible = true;

           
                

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
