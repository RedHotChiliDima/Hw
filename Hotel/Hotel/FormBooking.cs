using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hotel
{
    public partial class FormBooking : Form
    {
        List<HotelInfo> currentHotels;
        HotelInfo currentHotel;
        int photoIndex = 0;
        int photoCount = 4;

        public FormBooking()
        {
            InitializeComponent();
        }

        private void FormBooking_Load(object sender, EventArgs e)
        {
            foreach (string dir in DataStore.Directions.Keys)
                comboBoxDirection.Items.Add(dir);

            foreach (string cat in DataStore.Categories)
                comboBoxCategory.Items.Add(cat);

            comboBoxCategory.SelectedIndex = 0;
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dir = comboBoxDirection.Text;
            if (!DataStore.Directions.ContainsKey(dir))
                return;

            currentHotels = DataStore.Directions[dir];
            comboBoxHotel.Items.Clear();
            foreach (HotelInfo h in currentHotels)
                comboBoxHotel.Items.Add(h.Name);

            comboBoxHotel.SelectedIndex = 0;
        }

        private void comboBoxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxHotel.SelectedIndex < 0)
                return;

            currentHotel = currentHotels[comboBoxHotel.SelectedIndex];
            photoIndex = 0;
            ShowPhoto();

            textBoxDescription.Text = currentHotel.Description;
            UpdatePrice();
        }

        void ShowPhoto()
        {
            if (currentHotel == null)
                return;

            string path = Path.Combine("Images", currentHotel.ImageKey + "_" + (photoIndex + 1) + ".jpg");

            if (pictureBoxHotel.Image != null)
            {
                pictureBoxHotel.Image.Dispose();
                pictureBoxHotel.Image = null;
            }

            if (File.Exists(path))
            {
                using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pictureBoxHotel.Image = Image.FromStream(fs);
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (currentHotel == null)
                return;
            photoIndex++;
            if (photoIndex >= photoCount)
                photoIndex = 0;
            ShowPhoto();
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (currentHotel == null)
                return;
            photoIndex--;
            if (photoIndex < 0)
                photoIndex = photoCount - 1;
            ShowPhoto();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }

        void UpdatePrice()
        {
            if (currentHotel == null)
                return;
            string cat = comboBoxCategory.Text;
            if (currentHotel.Prices.ContainsKey(cat))
                labelPrice.Text = "Стоимость за сутки: " + currentHotel.Prices[cat] + " руб.";
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            if (currentHotel == null)
            {
                MessageBox.Show("Выберите гостиницу");
                return;
            }
            if (!maskedTextBoxPhone.MaskCompleted)
            {
                MessageBox.Show("Введите номер телефона полностью");
                return;
            }

            string cat = comboBoxCategory.Text;
            int price = currentHotel.Prices[cat];

            FormResult result = new FormResult(
                comboBoxDirection.Text,
                currentHotel.Name,
                cat,
                price,
                maskedTextBoxPhone.Text);
            result.ShowDialog();
        }

        private void pictureBoxHotel_Click(object sender, EventArgs e)
        {

        }

        private void labelDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
