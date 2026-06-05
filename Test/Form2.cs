using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test
{
    public partial class Form2 : Form
    {
        List<string> names = new List<string>();
        List<string> questions = new List<string>();

        List<string> right_words = new List<string>();

        int count_mas = 0;
        int count_questions = 0;

        int count_right_words = 0;


        public void dataInMassiv()
        {
            string[] allLines = File.ReadAllLines("second.txt");

            // Используем списки для динамического добавления элементов
            

            int count = 0;
            string word = "";

            foreach (string line in allLines)
            {
                
                if (count == 0)
                {
                    names.Add(line); // Добавляем имя
                }
                else
                {
                    char lastChar = line[line.Length - 1];
                    
                    if (lastChar == '+')
                    {
                        word = line.Substring(0, line.Length - 1);
                        right_words.Add(word);
                        questions.Add(word);

                    }
                    else
                    {
                        questions.Add(line); // Добавляем вопрос
                    }
                        
                }

                count = (count + 1) % 5; // Сбрасываем счётчик каждые 5 строк
            }

            // Преобразуем списки в массивы, если нужно
            string[] namesArray = names.ToArray();
            string[] questionsArray = questions.ToArray();

            //label1.Text = string.Join(Environment.NewLine, right_words); // Все вопросы через перенос строки
        }

        public void clickButton()
        {

    

                RadioButton[] radioButtons = { radioButton8, radioButton7, radioButton6, radioButton5 };
                bool isCorrect = false;

                foreach (var rb in radioButtons)
                {
                    if (rb.Checked && rb.Text.Equals(right_words[count_mas]))
                    {
                        isCorrect = true;
                        count_right_words++;
                    break;

                    }

                }
      

                count_mas++;

            if (count_mas == names.Count)
            {

                
                this.Visible = false;
                Form3 form3 = new Form3(count_right_words,names.Count);
                form3.ShowDialog();
                this.Close();
            }
            else
            {
                nextQuestion();
            }





        }

        public void nextQuestion()
        {
            label2.Text = names[count_mas];

            radioButton8.Text = questions[count_questions++];
            radioButton7.Text = questions[count_questions++];
            radioButton6.Text = questions[count_questions++];
            radioButton5.Text = questions[count_questions++];
        }
        public Form2()
        {
            InitializeComponent();
            dataInMassiv();
            label2.Text = "";
            radioButton8.Text = "";
            radioButton7.Text = "";
            radioButton6.Text = "";
            radioButton5.Text = "";
            nextQuestion();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          clickButton();
        }
    }
}
