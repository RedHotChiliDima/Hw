using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form3 : Form
    {
        public void rate(int count, int lenght)
        {
            label1.Text += count + " из " + lenght;
            switch (count)
            {
                case 0:
                case 1:
                case 2:
                    label3.Text += "Неудовлетворительно"; 
                    break;
                case 3: case 4:
                    label3.Text += "Удовлетворительно";
                    break;
                case 5:
                    label3.Text += "Отлично";
                    break;
            }
           
        }
        public Form3(int count,int lenght)
        {
            InitializeComponent();
            rate(count,lenght);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
